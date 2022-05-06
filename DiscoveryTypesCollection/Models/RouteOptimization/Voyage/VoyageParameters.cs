namespace Navtor.Advisory.Models.Models.RouteOptimization.Voyage
{
    /// <summary>
    /// Voyage Parameters for Route Optimization Request
    /// </summary>
    public class VoyageParameters
    {
        public VoyageLimitations? VoyageLimitations { get; set; }

        public CostValue? DailyHire { get; set; }
    }
}