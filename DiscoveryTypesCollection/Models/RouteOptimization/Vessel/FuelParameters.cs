namespace Navtor.Advisory.Models.Models.RouteOptimization.Vessel
{
    /// <summary>
    /// Fuel Parameters for Route Optimization Request
    /// </summary>
    public class FuelParameters
    {
        public FuelType FuelType { get; set; }

        /// <summary>
        /// Fuel Cost Inside ECA for the Given Fuel Type
        /// </summary>
        public CostValue? FuelCostInsideEca { get; set; }

        /// <summary>
        /// Fuel Cost Outside ECA for the Given Fuel Type
        /// </summary>
        public CostValue? FuelCostOutsideEca { get; set; }
    }
}
