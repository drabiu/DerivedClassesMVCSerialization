using System;
using Navtor.Spatial.Models;

namespace Navtor.Advisory.Models.Models.RouteOptimization.Inputs
{
    /// <summary>
    /// Route intermediate point. Can be either location or a port
    /// </summary>
    public class RouteIntermediatePosition
    {
        public string? Country { get; set; }

        public string? PortName { get; set; }

        public string? PortUnlocode { get; set; }

        public DateTime Eta { get; set; }

        public DateTime Etd { get; set; }

        public Point? Location { get; set; }
    }
}
