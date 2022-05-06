using System.Collections.Generic;
using System.Linq;

namespace Navtor.Advisory.Models.Models.RouteOptimization.Inputs
{
    /// <summary>
    /// Input Data for Route Optimization Request of A-to-B-via-C type
    /// </summary>
    public class AtoBViaCInput : RouteInput
    {
        /// <summary>
        /// Start, end and intermediate route positions
        /// </summary>
        // At the moment OptimumVoyage doesn't support intermediate Ports, but locations can be used in that case.
        public IEnumerable<RouteIntermediatePosition> IntermediatePositions { get; set; } = Enumerable.Empty<RouteIntermediatePosition>();
    }
}