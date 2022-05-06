using System;

namespace Navtor.Advisory.Models.Models.RouteOptimization.Inputs
{
    /// <summary>
    /// Input Data for Route Optimization Request of GivenRoute type
    /// </summary>
    public class GivenRouteInput : RouteInput
    {
        public DateTime Eta { get; set; }

        public DateTime Etd { get; set; }

        public RouteData? Route { get; set; }

        public GivenRouteInputRouteExtension? RouteExtension { get; set; }
    }
}