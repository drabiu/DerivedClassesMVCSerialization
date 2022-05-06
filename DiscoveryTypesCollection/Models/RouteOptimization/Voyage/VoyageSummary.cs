using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
namespace Navtor.Advisory.Models.Models.RouteOptimization.Voyage
{
    public class VoyageSummary
    {
        /// <summary>
        /// Distance Over Ground, nm
        /// </summary>
        public double? DistanceOverGround { get; set; }

        /// <summary>
        /// Distance through water, nm
        /// </summary>
        public double? DistanceThroughWater { get; set; }

        // TODO: should we do it for each type of fuel?
        public TotalConsumptionValue? FuelOilConsumptionInsideEca { get; set; }

        // TODO: should we do it for each type of fuel?
        public CostValue? FuelOilCostInsideEca { get; set; }

        // TODO: should we do it for each type of fuel?
        public TotalConsumptionValue? FuelOilConsumptionOutsideEca { get; set; }

        // TODO: should we do it for each type of fuel?
        public CostValue? FuelOilCostOutsideEca { get; set; }

        public CostValue? HireCost { get; set; }

        public IEnumerable<CostValue>? TotalCost { get; set; }

        [JsonConverter(typeof(JsonTimeSpanConverter))]
        public TimeSpan TotalDuration { get; set; }

        public bool IsSafeWeather { get; set; }
    }
}
