using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Models
{
    public class Order
    {
        public Order(RouteOption selectedRoute, User userInfo, Payment paymentInfo, 
            Address deliveryAddress, string comment)
        {
            Id = Guid.NewGuid();
            SelectedRoute = selectedRoute;
            UserInfo = userInfo;
            PaymentInfo = paymentInfo;
            DeliveryAddress = deliveryAddress;
            Comment = comment;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] public Guid Id { get; private set; }
        public RouteOption SelectedRoute { get; set; }
        public User UserInfo { get; set; }
        public Payment PaymentInfo { get; set; }
        public Address DeliveryAddress { get; set; }
        public string Comment { get; set; }
    }
}