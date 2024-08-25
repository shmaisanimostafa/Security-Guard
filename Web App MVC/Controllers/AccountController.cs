using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Shared.Models;
using System.Security.Claims;
//using Security_Guard.Models;
//using Security_Guard.Models.AccountManagement;


namespace Security_Guard.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<User> userManager;
        private SignInManager<User> signInManager;

        public AccountController(UserManager<User> usrManager, SignInManager<User> signInMngr)
        {
            this.userManager = usrManager;
            this.signInManager = signInMngr;
        }

        //Register Action

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new User
                {
                    UserName = model.Username,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Email = model.Email,
                    ImageURL = model.ImageURL,
                    Name = model.FirstName + model.LastName,
                    //ConfirmEmail = model.Email,
                };

                var result = await userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    bool isPersistent = false;
                    await signInManager.SignInAsync(user, isPersistent);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            return View(model);
        }


        //Logout Action

        [HttpPost]
        public async Task<IActionResult> LogOut()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        //Login Action

        [HttpGet]
        public IActionResult LogIn(string returnURL = "")
        {
            var model = new LoginViewModel { ReturnUrl = returnURL };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> LogIn(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await signInManager.PasswordSignInAsync(
                    model.Username, model.Password, isPersistent: model.RememberMe,
                    lockoutOnFailure: false);

                if (result.Succeeded)
                {
                    if (!string.IsNullOrEmpty(model.ReturnUrl) &&
                        Url.IsLocalUrl(model.ReturnUrl))
                    {
                        return Redirect(model.ReturnUrl);
                    }
                    else
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }
            }
            ModelState.AddModelError("", "Invalid username/password.");
            return View(model);
        }

        [HttpGet]
        public IActionResult GoogleLogin(string returnUrl = "/")
        {
            var properties = new AuthenticationProperties
            {
                RedirectUri = Url.Action("GoogleResponse", new { ReturnUrl = returnUrl })
            };
            return Challenge(properties, GoogleDefaults.AuthenticationScheme);
        }

        [HttpGet]
        public async Task<IActionResult> GoogleResponse(string returnUrl = "/")
        {
            var result = await HttpContext.AuthenticateAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            if (result.Succeeded)
            {
                var user = await userManager.FindByEmailAsync(result.Principal.FindFirstValue(ClaimTypes.Email));
                if (user == null)
                {
                    user = new User
                    {
                        UserName = result.Principal.FindFirstValue(ClaimTypes.Name),
                        Email = result.Principal.FindFirstValue(ClaimTypes.Email)
                    };
                    var creationResult = await userManager.CreateAsync(user);
                    if (!creationResult.Succeeded)
                    {
                        ModelState.AddModelError("", "Error creating user");
                        return View("Error");
                    }
                }

                await signInManager.SignInAsync(user, isPersistent: false);
                return Redirect(returnUrl);
            }

            return RedirectToAction("LogIn");
        }

        public ViewResult AccessDenied()
        {
            return View();
        }
        [HttpGet]
        public IActionResult ChangePassword()
        {
            var model = new ChangePasswordViewModel
            {
                Username = User.Identity?.Name ?? ""
            };
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> ChangePassword(ChangePasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                User user = await userManager.FindByNameAsync(model.Username);
                var result = await userManager.ChangePasswordAsync(user,
                model.OldPassword, model.NewPassword);
                if (result.Succeeded)
                {
                    TempData["message"] = "Password changed successfully";
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    foreach (IdentityError error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> UpdateProfile()
        {
            // Get the current user
            var user = await userManager.GetUserAsync(User);

            // Map the user properties to the UserProfileViewModel
            var model = new UserProfileViewModel
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Username = user.UserName,
                ImageURL = user.ImageURL,
                Email = user.Email,
                // Map other properties as needed
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateProfile(UserProfileViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Get the current user
                var user = await userManager.GetUserAsync(User);

                // Update user properties with values from the model
                user.FirstName = model.FirstName;
                user.LastName = model.LastName;
                user.UserName = model.Username;
                user.ImageURL = model.ImageURL;
                user.Email = model.Email;

                // Update the user in the database
                var result = await userManager.UpdateAsync(user);

                if (result.Succeeded)
                {
                    TempData["message"] = "Profile updated successfully";
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }

            // If the model is not valid, return to the view with the model
            return View(model);
        }

    }

}
