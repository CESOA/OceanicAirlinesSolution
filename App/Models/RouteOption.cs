using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Models
{
    /// <summary>
    ///     The model that represents a Route between specific cities.
    /// </summary>
    public class RouteOption
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] public Guid Id { get; private set; }
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