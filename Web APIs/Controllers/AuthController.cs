using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Security_Guard.Models;
using Microsoft.AspNetCore.Authorization;
using Security_Guard_API.Models;
using Shared.Models;

namespace Security_Guard.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IConfiguration _configuration;

        public AuthController(UserManager<User> userManager, SignInManager<User> signInManager, IConfiguration configuration)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _configuration = configuration;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.Password != model.ConfirmPassword)
                {
                    return BadRequest("Passwords do not match.");
                }

                var user = new User
                {
                    UserName = model.Username,
                    Email = model.Email,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    ImageURL = model.ImageURL
                };

                var result = await _userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    return Ok(new { Message = "User registered successfully" });
                }

                return BadRequest(result.Errors);
            }

            return BadRequest(ModelState);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginModel model)
        {
            var result = await _signInManager.PasswordSignInAsync(model.Username, model.Password, false, lockoutOnFailure: false);

            if (result.Succeeded)
            {
                var user = await _userManager.FindByNameAsync(model.Username);
                var token = GenerateJwtToken(user);
                return Ok(new { Token = token });
            }

            return Unauthorized();
        }

        [HttpPost("refresh")]
        public IActionResult Refresh([FromBody] TokenModel tokenModel)
        {
            // Validate the refresh token (implementation depends on how tokens are stored)
            // This example assumes a simplistic approach where refresh token is the JWT itself

            if (string.IsNullOrEmpty(tokenModel.Token))
            {
                return BadRequest("Invalid token.");
            }

            var tokenHandler = new JwtSecurityTokenHandler();
            var jwtToken = tokenHandler.ReadToken(tokenModel.Token) as JwtSecurityToken;

            if (jwtToken == null || !jwtToken.Header.Alg.Equals(SecurityAlgorithms.HmacSha256, StringComparison.InvariantCultureIgnoreCase))
            {
                return BadRequest("Invalid token.");
            }

            var userName = jwtToken.Claims.First(x => x.Type == JwtRegisteredClaimNames.Sub).Value;
            var user = _userManager.FindByNameAsync(userName).Result;

            if (user == null)
            {
                return BadRequest("User not found.");
            }

            var newToken = GenerateJwtToken(user);
            return Ok(new { Token = newToken });
        }

        [HttpPost("logout")]
        public IActionResult Logout()
        {
            // In a stateless API, you don't need to explicitly log out the user.
            // The client should just discard the token.
            return Ok(new { Message = "Logged out successfully" });
        }

        [HttpPost("forgot-password")]
        public async Task<IActionResult> ForgotPassword([FromBody] ForgotPasswordModel model)
        {
            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user == null)
            {
                return BadRequest("User not found.");
            }

            var token = await _userManager.GeneratePasswordResetTokenAsync(user);
            // Send token via email or other means (not implemented here)
            return Ok(new { Token = token });
        }

        [HttpPost("reset-password")]
        public async Task<IActionResult> ResetPassword([FromBody] ResetPasswordModel model)
        {
            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user == null)
            {
                return BadRequest("User not found.");
            }

            var result = await _userManager.ResetPasswordAsync(user, model.Token, model.NewPassword);
            if (result.Succeeded)
            {
                return Ok(new { Message = "Password reset successful" });
            }

            return BadRequest(result.Errors);
        }

        [HttpPut("update-profile")]
        public async Task<IActionResult> UpdateProfile([FromBody] UpdateProfileModel model)
        {
            var user = await _userManager.FindByNameAsync(model.Username);
            if (user == null)
            {
                return BadRequest("User not found.");
            }

            user.FirstName = model.FirstName;
            user.LastName = model.LastName;
            user.Email = model.Email;
            user.ImageURL = model.ImageURL;

            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                return Ok(new { Message = "Profile updated successfully" });
            }

            return BadRequest(result.Errors);
        }

        [HttpDelete("delete-account")]
        public async Task<IActionResult> DeleteAccount([FromBody] DeleteAccountModel model)
        {
            var user = await _userManager.FindByNameAsync(model.Username);
            if (user == null)
            {
                return BadRequest("User not found.");
            }

            // Verify the password
            var result = await _signInManager.CheckPasswordSignInAsync(user, model.Password, lockoutOnFailure: false);
            if (!result.Succeeded)
            {
                return Unauthorized("Invalid password.");
            }

            // Proceed with account deletion
            var deleteResult = await _userManager.DeleteAsync(user);
            if (deleteResult.Succeeded)
            {
                return Ok(new { Message = "Account deleted successfully" });
            }

            return BadRequest(deleteResult.Errors);
        }

        [HttpGet("user-data")]
        public async Task<IActionResult> GetUserData([FromQuery] string token)
        {
            // Debug: Log the start of the method
            Console.WriteLine("GetUserData method called.");

            // Debug: Log the received token
            Console.WriteLine($"Received token: {token}");

            if (string.IsNullOrEmpty(token))
            {
                Console.WriteLine("Token is null or empty.");
                return BadRequest("Token is required.");
            }

            // Extract the username from the JWT token claims
            var userName = GetUserNameFromToken(token);

            // Debug: Log the extracted username
            Console.WriteLine($"Extracted username from token: {userName}");

            if (string.IsNullOrEmpty(userName))
            {
                // Debug: Log the issue with the username
                Console.WriteLine("Username not found in the token.");
                return BadRequest("User not found.");
            }

            // Find the user by username
            var user = await _userManager.FindByNameAsync(userName);

            // Debug: Log whether the user was found or not
            if (user == null)
            {
                Console.WriteLine($"User not found for username: {userName}");
                return BadRequest("User not found.");
            }

            // Debug: Log user details before creating the response model
            Console.WriteLine($"User found: {user.UserName}, Email: {user.Email}");

            // Create a response model
            var userData = new UserDataModel
            {
                UserName = user.UserName,
                Email = user.Email,
                FirstName = user.FirstName,
                LastName = user.LastName,
                ImageURL = user.ImageURL,
                //Roles = user.RoleNames // Add other properties if needed
            };

            // Debug: Log the user data being returned
            Console.WriteLine($"Returning user data: {userData}");

            return Ok(userData);
        }

        private string GetUserNameFromToken(string token)
        {
            // Implement logic to decode JWT and extract username
            try
            {
                var handler = new JwtSecurityTokenHandler();
                var jwtToken = handler.ReadJwtToken(token);
                var userName = jwtToken.Claims.FirstOrDefault(c => c.Type == JwtRegisteredClaimNames.Sub)?.Value;
                return userName;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error decoding token: {ex.Message}");
                return null;
            }
        }




        private string GenerateJwtToken(User user)
        {
            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.UserName),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: _configuration["Jwt:Issuer"],
                audience: _configuration["Jwt:Issuer"],
                claims: claims,
                expires: DateTime.Now.AddHours(1),
                signingCredentials: creds);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
