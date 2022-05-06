namespace Navtor.Advisory.Models.Models.RouteOptimization.Voyage
{
    public class VoyageLimitations
    {
        /// <summary>
        /// Max Allowed Fuel Cost
        /// </summary>
        public CostValue? MaxFuelCost { get; set; }

        /// <summary>
        /// Max Allowed Fuel Consumption defined by Charter Party
        /// </summary>
        public AverageConsumptionValue? MaxFuelConsumption { get; set; }

        /// <summary>
        /// Max speed defined by Charter Party, kn
        /// </summary>
        public double? MaxSpeed { get; set; }

        public uint? MaxPowerRpm { get; set; }
    }
}
