namespace Navtor.Advisory.Models.Models.RouteOptimization.RequestProcessing
{
    public class RequestProcessingType
    {
        public ProcessingType Type { get; set; }

        /// <summary>
        /// Request Period Timestamp/Event indicating when to start the request processing
        /// </summary>
        public RequestPeriodValue? PeriodStart { get; set; }

        /// <summary>
        /// Request Period Timestamp/Event indicating when to stop the request processing
        /// </summary>
        public RequestPeriodValue? PeriodEnd { get; set; }

        /// <summary>
        /// Update frequency in case of continuous request
        /// </summary>
        public ContinuousRequestUpdateFrequency? UpdateFrequency { get; set; }
    }
}
