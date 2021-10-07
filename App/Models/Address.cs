namespace App.Models
{
    public class Address
    {
        public Address(string name, string email, string phoneNo, string street, string streetNo, string zipCode, string city, string country)
        {
            Name = name;
            Email = email;
            PhoneNo = phoneNo;
            Street = street;
            StreetNo = streetNo;
            ZipCode = zipCode;
            City = city;
            Country = country;
        }

        private string Name { get; set; }
        private string Email { get; set; }
        private string PhoneNo { get; set; }
        private string Street { get; set; }
        private string StreetNo { get; set; }
        private string ZipCode { get; set; }
        private string City { get; set; }
        private string Country { get; set; }
    }
}