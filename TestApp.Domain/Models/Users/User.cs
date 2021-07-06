namespace TestApp.Domain.Models.Users
{
    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public UserRole UserRole { get; set; }
        public UserAddress UserAddress { get; set; }
    }
}