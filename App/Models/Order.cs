using System;

namespace App.Models
{
    public class Order
    {
        // private User UserInfo { get; set; } todo!
        // private RouteOption RouteOption { get; set; } todo!
        public Order(string routeOption, string userInfo, Payment paymentInfo, Address deliveryAddress, string comment)
        {
            Id = Guid.NewGuid();
            RouteOption = routeOption;
            UserInfo = userInfo;
            PaymentInfo = paymentInfo;
            DeliveryAddress = deliveryAddress;
            Comment = comment;
        }

        private Guid Id { get;}
        private string RouteOption { get; set; }
        private string UserInfo { get; set; }
        private Payment PaymentInfo { get; set; }
        private Address DeliveryAddress { get; set; }
        private string Comment { get; set; }
    }
}