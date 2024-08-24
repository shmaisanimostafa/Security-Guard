namespace Security_Guard_API.Models
{
    public class UserDataModel
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ImageURL { get; set; }
        //public IList<string> Roles { get; set; } // Include additional fields as needed
    }
}
