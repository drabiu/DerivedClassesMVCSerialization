using System;

namespace Navtor.Advisory.Models.Models.RouteOptimization.RequestProcessing
{
    /// <summary>
    /// A timestamp, or event when a request can start/end
    /// </summary>
    public class RequestPeriodValue
    {
        public PeriodType? Type { get; set; }

        public DateTime Timestamp { get; set; }

        public PeriodEventType Event { get; set; }
    }
}
