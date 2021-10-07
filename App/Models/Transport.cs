using System;
using System.ComponentModel.DataAnnotations;

namespace App.Models
{
    public class Transport
    {
        public Transport(string company, Guid bookingId, Guid transportId, string cityFrom, string cityTo, double weight, PackageType type)
        {
            Company = company;
            BookingId = bookingId;
            TransportId = transportId;
            CityFrom = cityFrom;
            CityTo = cityTo;
            Weight = weight;
            Type = type;
            Id = Guid.NewGuid();
        }

        [Key] public Guid Id { get; private set; }
        public string Company { get; private set; }
        public Guid BookingId { get; private set; }
        public Guid TransportId { get; private set; }
        public string CityFrom { get; private set; }
        public string CityTo { get; private set; }
        public double Weight { get; private set; }
        public PackageType Type { get; private set; }
    }
}