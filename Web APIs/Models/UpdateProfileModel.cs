namespace Security_Guard.Models
{
    public class UpdateProfileModel
    {
        public string Username { get; set; }    // Property to identify the user whose profile is being updated
        public string Email { get; set; }       // Updated email address
        public string FirstName { get; set; }   // Updated first name
        public string LastName { get; set; }    // Updated last name
        public string ImageURL { get; set; }    // Updated profile image URL
    }
}
