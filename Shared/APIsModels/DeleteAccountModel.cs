namespace Security_Guard.Models
{
    public class DeleteAccountModel
    {
        public string Username { get; set; }
        public string Password { get; set; }  // To confirm the identity of the user requesting the deletion
    }
}
