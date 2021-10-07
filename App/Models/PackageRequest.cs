namespace App.Models
{
    public class PackageRequest
    {
        private readonly double depth;
        private readonly string from;
        private readonly double length;
        private readonly string to;
        private readonly double width;

        public PackageRequest(string from, string to, double width, double length, double depth)
        {
            this.from = from;
            this.to = to;
            this.width = width;
            this.length = length;
            this.depth = depth;
        }
    }
}