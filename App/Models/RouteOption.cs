using System;
using System.ComponentModel.DataAnnotations;

namespace App.Models
{
    /// <summary>
    ///     The model that represents a Route between specific cities.
    /// </summary>
    public class RouteOption
    {
        [Key] public Guid Id { get; private set; }
        public DateTime ExpectedDeliveryTime { get; private set; }
        public double Price { get; private set; }
        public PackageRequest PackageRequest { get; }

        public RouteOption(DateTime expectedDeliveryTime, double price, PackageRequest packageRequest)
        {
            ExpectedDeliveryTime = expectedDeliveryTime;
            Price = price;
            PackageRequest = packageRequest;
        }
    }
}