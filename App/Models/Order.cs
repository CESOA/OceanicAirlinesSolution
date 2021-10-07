using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Models
{
    public class Order
    {
        public Order(RouteOption selectedRoute, User userInfo, Payment paymentInfo, Address deliveryAddress, string comment)
        {
            Id = Guid.NewGuid();
            SelectedRoute = selectedRoute;
            UserInfo = userInfo;
            PaymentInfo = paymentInfo;
            DeliveryAddress = deliveryAddress;
            Comment = comment;
        }

        [Key] public Guid Id { get;}
        [ForeignKey("Id")] public RouteOption SelectedRoute { get; set; }
        [ForeignKey("Id")] public User UserInfo { get; set; }
        [ForeignKey("Id")] public Payment PaymentInfo { get; set; }
        [ForeignKey("Id")] public Address DeliveryAddress { get; set; }
        public string Comment { get; set; }
    }
}