using System.ComponentModel.DataAnnotations;

namespace Security_Guard.Models.AccountManagement
{
    public class UserProfileViewModel
    {
        [Required(ErrorMessage = "Please enter a first name.")]
        [StringLength(255)]
        public string FirstName { get; set; } = string.Empty;
        [Required(ErrorMessage = "Please enter a last name.")]
        [StringLength(255)]
        public string LastName { get; set; } = string.Empty;
        [Required(ErrorMessage = "Please enter a Image URL")]
        [StringLength(255)]
        public string ImgURL { get; set; } = string.Empty;
        [Required(ErrorMessage = "Please enter a username.")]
        [StringLength(255)]
        public string Username { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

    }
}
