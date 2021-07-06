namespace TestApp.Domain.Models.Users
{
    public class UserAddress
    {
        public int UserAddressId { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
    }
}