using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        [Key] 
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string PhoneNo { get; private set; }
        public string Street { get; private set; }
        public string StreetNo { get; private set; }
        public string ZipCode { get; private set; }
        public string City { get; private set; }
        public string Country { get; private set; }
    }
}