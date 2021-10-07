using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Models
{
    /// <summary>
    ///     The model that represents a Route between specific cities.
    /// </summary>
    public class Route
    {
        public Route(string cityFrom, string cityTo, double weight, int duration, double cost, PackageType type)
        {
            CityFrom = cityFrom;
            CityTo = cityTo;
            Weight = weight;
            Duration = duration;
            Cost = cost;
            Type = type;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] public Guid Id { get; private set; }
        public string CityFrom { get; private set; }
        public string CityTo { get; private set; }
        public double Weight { get; private set; }
        public int Duration { get; private set; }
        public PackageType Type { get; private set; }
        public double Cost { get; private set; }
    }
}