using System;

namespace App.Models
{
    /// <summary>
    ///     The model that represents a Route between specific cities.
    /// </summary>
    public class RouteOption
    {
        private readonly DateTime expectedDeliveryTime;
        private readonly Order order;
        private readonly double price;
        private readonly PackageRequest rackageRequest;

        public RouteOption(DateTime expectedDeliveryTime, double price, Order order, PackageRequest rackageRequest)
        {
            this.expectedDeliveryTime = expectedDeliveryTime;
            this.price = price;
            this.order = order;
            this.rackageRequest = rackageRequest;
        }
    }
}