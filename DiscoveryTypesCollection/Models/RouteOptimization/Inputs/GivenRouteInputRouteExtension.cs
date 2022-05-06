using System.Collections.Generic;
using System.Linq;

namespace Navtor.Advisory.Models.Models.RouteOptimization.Inputs
{
    public class GivenRouteInputRouteExtension
    {
        public IEnumerable<GivenRouteInputWaypointExtension> Waypoints { get; set; } = Enumerable.Empty<GivenRouteInputWaypointExtension>();
        // TODO:
    }
}
