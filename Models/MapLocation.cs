using System;
namespace miniblog.Models
{
    public class MapLocation
    {

        public int id { get; set; }
        public string name { get; set; }
        public string slug { get; set; }
        public string type { get; set; }
        public double[] coords { get; set; }

    }
}
