using System;

namespace App.Models
{
    public class Order
    {
        // private RouteOption RouteOption { get; set; } todo!
        public Order(RouteOption selectedRoute, User userInfo, Payment paymentInfo, Address deliveryAddress, string comment)
        {
            Id = Guid.NewGuid();
            SelectedRoute = selectedRoute;
            UserInfo = userInfo;
            PaymentInfo = paymentInfo;
            DeliveryAddress = deliveryAddress;
            Comment = comment;
        }

        private Guid Id { get;}
        private RouteOption SelectedRoute { get; set; }
        private User UserInfo { get; set; }
        private Payment PaymentInfo { get; set; }
        private Address DeliveryAddress { get; set; }
        private string Comment { get; set; }
    }
}