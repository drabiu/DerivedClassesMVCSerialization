using Navtor.Advisory.Models.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace Navtor.Advisory.Models.Models
{
    /// <summary>
    /// Advisory Service Response
    /// </summary>
    public class ResponseObject
    {
        /// <summary>
        /// Response Id. Is generated on the server. Can be ignored when posting data.
        /// </summary>
        public Guid ResponseId { get; set; }

        public Guid RequestId { get; set; }

        public AdvisoryType AdvisoryType { get; set; }

        public DateTime CreatedDateTime { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// Advices. Currently RouteOptimizationAdvice is supported
        /// </summary>
        public object[] Advices { get; set; } = Array.Empty<object>();
    }
}