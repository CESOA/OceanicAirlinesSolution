using System;
using System.Collections;
using System.Collections.Generic;
using App.App_Data.Database;
using App.Models;

// TODO: Uncomment all
namespace App.App_Data.RouteManagement
{
    public class RouteManager
    {
        private readonly RouteCalculator routeCalculator;
        private readonly TransportRepository transportRepository;

        public RouteManager(RouteCalculator routeCalculator, TransportRepository transportRepository)
        {
            this.routeCalculator = routeCalculator;
            this.transportRepository = transportRepository;
        }

        // public IEnumerable<RouteOption> GetRoutes(RouteRequest routeRequest)
        // {
        //
        //
        //     
        //     return transportRepository.GetRoutes(orderByExpression, whereExpression);
        // }
        //
        // public RouteOption CreateTransport(PackageRequest packageRequest)
        // {
        //     var routeOption = routeCalculator.CalculateRoute(packageRequest);
        //
        //     if (transportRepository.PersistTransport(routeOption))
        //         return routeOption;
        //
        //     throw new ArgumentException("Could not persist the route!");
        // }
    }
}