using System;
using System.Collections.Generic;

namespace Navtor.Advisory.Models.Models.RouteOptimization
{
    /// <summary>
    /// Extension for route waypoint
    /// </summary>
    public class AdviceWaypointExtension
    {
        public DateTime Eta { get; set; }

        /// <summary>
        /// Indicates that the waypoint is fixed and cannot be moved
        /// </summary>
        public bool IsWaypointFixed { get; set; }

        /// <summary>
        /// Indicates that outgoing leg is fixed and cannot be changed
        /// </summary>
        public bool IsLegFixed { get; set; }

        public double? SpeedRestrictionMinSpeed { get; set; }

        public double? SpeedRestrictionMaxSpeed { get; set; }

        public uint? Rpm { get; set; } // TODO: Make Engine Parameters instead?

        public uint? EngineLoadPercentage { get; set; }

        // TODO: should we do it for each type of fuel?
        public CostValue? FuelOilCostInsideEca { get; set; }

        // TODO: should we do it for each type of fuel?
        public TotalConsumptionValue? FuelOilConsumptionOutsideEca { get; set; }

        // TODO: should we do it for each type of fuel?
        /// <summary>
        /// Average Fuel Oil Consumption on Leg
        /// </summary>
        public AverageConsumptionValue? FuelOilConsumptionAverageOnLeg { get; set; }

        // TODO: maybe we don't need it here (we can calculate it based on the route)
        /// <summary>
        /// Outgoing leg length, nm
        /// </summary>
        public double? LegLength { get; set; }

        // TODO: maybe we don't need it here (we can calculate it based on the route)
        /// <summary>
        /// Heading, degrees
        /// </summary>
        public double? Heading { get; set; }

        /// <summary>
        /// Weather in the waypoint
        /// </summary>
        public IDictionary<string, object> Weather { get; set; } = new Dictionary<string, object>();
    }
}
