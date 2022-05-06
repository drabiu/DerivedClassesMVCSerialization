using System.Collections.Generic;
using System.Linq;

namespace Navtor.Advisory.Models.Models.RouteOptimization
{
    public class AdviceRouteExtension
    {
        /// <summary>
        /// Additional info for route waypoints
        /// </summary>
        public IEnumerable<AdviceWaypointExtension> Waypoints { get; set; } = Enumerable.Empty<AdviceWaypointExtension>();
    }
}
