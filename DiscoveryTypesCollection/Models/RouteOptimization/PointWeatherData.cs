using System;
using System.Collections.Generic;
using Navtor.Spatial.Models;

namespace Navtor.Advisory.Models.Models.RouteOptimization
{
    public class PointWeatherData
    {
        public Point? Location { get; set; }

        public DateTime Timestamp { get; set; }

        /// <summary>
        /// Weather Values
        /// </summary>
        public IDictionary<string, object> Values { get; set; } = new Dictionary<string, object>();
    }
}
