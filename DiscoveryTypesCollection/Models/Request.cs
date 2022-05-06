using System;
using System.Collections.Generic;
using System.Linq;
using Navtor.Advisory.Models.Converters;
using Newtonsoft.Json;

namespace Navtor.Advisory.Models.Models
{
    /// <summary>
    /// Advisory Service Request
    /// </summary>
    public class Request
    {
        public Guid RequestId { get; set; }

        public Guid? ParentRequestId { get; set; }

        public AdvisoryType AdvisoryType { get; set; }

        public DateTime CreatedDateTime { get; set; } = DateTime.UtcNow;

        public int VesselImo { get; set; }

        /// <summary>
        /// Request Domain specific data. See specific advisory types models for more details.
        /// </summary>
        [JsonConverter(typeof(CollectionOfDerivedClassesConverter<RequestData>))]
        public IEnumerable<RequestData> Data { get; set; } = Enumerable.Empty<RequestData>();
    }
}