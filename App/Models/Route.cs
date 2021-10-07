﻿using System;
using System.ComponentModel.DataAnnotations;

namespace App.Models
{
    /// <summary>
    ///     The model that represents a Route between specific cities.
    /// </summary>
    public class Route
    {
        public Route(string cityFrom, string cityTo, double weight, int duration, double cost, PackageType type, Guid id)
        {
            CityFrom = cityFrom;
            CityTo = cityTo;
            Weight = weight;
            Duration = duration;
            Cost = cost;
            Type = type;
            Id = id;
        }

        [Key] public Guid Id { get; private set; }
        public string CityFrom { get; private set; }
        public string CityTo { get; private set; }
        public double Weight { get; private set; }
        public int Duration { get; private set; }
        public PackageType Type { get; private set; }
        public double Cost { get; private set; }
    }
}