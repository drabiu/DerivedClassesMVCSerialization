namespace Navtor.Advisory.Models.Models.RouteOptimization.Inputs
{
    public class GivenRouteInputWaypointExtension
    {
        /// <summary>
        /// Indicates that the waypoint is fixed and cannot be moved
        /// </summary>
        public bool IsWaypointFixed { get; set; }

        /// <summary>
        /// Indicates that outgoing leg is fixed and cannot be changed
        /// </summary>
        public bool IsLegFixed { get; set; }

        /// <summary>
        /// Minimum speed on the outgoing leg, knots
        /// </summary>
        public double? MinSpeedOnLeg { get; set; }

        /// <summary>
        /// Maximum speed on the outgoing leg, knots
        /// </summary>
        public double? MaxSpeedOnLeg { get; set; }
    }
}
