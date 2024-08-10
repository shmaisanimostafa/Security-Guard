using System.ComponentModel.DataAnnotations;
namespace Security_Guard.Models.AccountManagement
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Please enter a first name.")]
        [StringLength(255)]
        public string FirstName { get; set; } = string.Empty;
        [Required(ErrorMessage = "Please enter a last name.")]
        [StringLength(255)]
        public string LastName { get; set; } = string.Empty;
        [Required(ErrorMessage = "Please enter a Image URL")]
        [StringLength(255)]
        public string ImageURL { get; set; } = string.Empty;
        [Required(ErrorMessage = "Please enter a username.")]
        [StringLength(255)]
        public string Username { get; set; } = string.Empty;
        [Required(ErrorMessage = "Please enter an email address.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } = string.Empty;
        public string ConfirmEmail { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a password.")]
        [DataType(DataType.Password)]
        [Compare("ConfirmPassword")]
        public string Password { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please confirm your password.")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; } = string.Empty;

    }
}
