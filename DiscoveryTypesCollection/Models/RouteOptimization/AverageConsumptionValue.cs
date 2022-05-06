using System;

namespace Navtor.Advisory.Models.Models.RouteOptimization
{
    public class AverageConsumptionValue
    {
        public string? Units { get; set; }

        public double Consumption { get; set; }

        public TimeSpan Period { get; set; }
    }
}
