using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string Phonenumber { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public bool LoggedStatus { get; private set; }
        public string Street { get; private set; }
        public string StreetNumber { get; private set; }
        public string City { get; private set; }
        public string ZipCode { get; private set; }
        public string Country { get; private set; }
    }
}