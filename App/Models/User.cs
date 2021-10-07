namespace App.Models
{
    public class User
    {
        public User(string name, string phonenumber, string email, string password, bool loggedStatus, string street,
            string streetNumber, string city, string zipCode, string country)
        {
            Name = name;
            Phonenumber = phonenumber;
            Email = email;
            Password = password;
            LoggedStatus = loggedStatus;
            Street = street;
            StreetNumber = streetNumber;
            City = city;
            ZipCode = zipCode;
            Country = country;
        }

        public string Name { get; }
        public string Phonenumber { get; }
        public string Email { get; }
        public string Password { get; }
        public bool LoggedStatus { get; }
        public string Street { get; }
        public string StreetNumber { get; }
        public string City { get; }
        public string ZipCode { get; }
        public string Country { get; }
    }
}