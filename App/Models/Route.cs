namespace App.Models
{
    /// <summary>
    ///     The model that represents a Route between specific cities.
    /// </summary>
    public class Route
    {
        public Route(string cityFrom, string cityTo, double weight, int duration, double cost, RouteType type)
        {
            CityFrom = cityFrom;
            CityTo = cityTo;
            Weight = weight;
            Duration = duration;
            Cost = cost;
            Type = type;
        }

        public string CityFrom { get; }
        public string CityTo { get; }
        public double Weight { get; }
        public int Duration { get; }
        public RouteType Type { get; }
        public double Cost { get; }
    }
}