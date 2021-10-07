using System;
using System.Web.Mvc;
using App.Models;
using App.Repositories;

namespace App.Controllers
{
    public class OrderController : Controller
    {
        private readonly OrderRepository orderRepository;

        public OrderController()
        {
            orderRepository = new OrderRepository();
        }
        public Order CreateOrder(RouteOption selectedRoute, User user, string cardholdersName, 
                string cardNo, string expirationDate, string cvv, string name, string email, 
                string phoneNo, string street, string streetNo, string zipCode, string city, 
                string country, string comment)
        {
            var order = new Order(selectedRoute, user, 
                new Payment(cardholdersName, cardNo, expirationDate, cvv),
                new Address(name, email, phoneNo, street, streetNo, zipCode, city, country), 
                comment);
            orderRepository.Create(order);
            return order;
        }

        public Order GetOrder(Guid id)
        {
            return orderRepository.Read(id);
        }
    }
}