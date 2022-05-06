using DiscoveryTypesCollection.Converters;
using Navtor.Advisory.Models.Models.RouteOptimization.Inputs;
using Navtor.Advisory.Models.Models.RouteOptimization.RequestProcessing;
using Navtor.Advisory.Models.Models.RouteOptimization.Vessel;
using Navtor.Advisory.Models.Models.RouteOptimization.Voyage;
using Newtonsoft.Json;

namespace Navtor.Advisory.Models.Models.RouteOptimization
{
    /// <summary>
    /// Data for Route Optimization Request
    /// </summary>
    public class AdviceRequestData : RequestData
    {
        /// <summary>
        /// Route Input. Shall correspond to the RouteInputType. RouteOptimizationAtoBViaCInput and RouteOptimizationGivenRouteInput are currently supported.
        /// </summary>
        [JsonConverter(typeof(DerivedClassesConverter<RouteInput>))]
        public RouteInput? RouteInput { get; set; }

        /// <summary>
        /// Request Processing Type. Indicates whether this is a one-time or continuous request
        /// </summary>
        public RequestProcessingType? RequestType { get; set; }

        public RouteOptimizationType OptimizationType { get; set; }

        public VesselModel? VesselModel { get; set; }

        public VesselParameters? VesselParameters { get; set; }

        public VoyageParameters? VoyageParameters { get; set; }
    }
}