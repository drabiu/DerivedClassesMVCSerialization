using Navtor.Advisory.Models.Models.RouteOptimization.Voyage;
using System.Collections.Generic;
using System.Linq;

namespace Navtor.Advisory.Models.Models.RouteOptimization
{
    public class RouteOptimizationAdvice : Advice
    {
        public VoyageSummary? VoyageSummary { get; set; }

        public RouteData? Route { get; set; }

        public AdviceRouteExtension? RouteExtension { get; set; }

        public IEnumerable<PointWeatherData> PointWeatherData { get; set; } = Enumerable.Empty<PointWeatherData>();
    }
}