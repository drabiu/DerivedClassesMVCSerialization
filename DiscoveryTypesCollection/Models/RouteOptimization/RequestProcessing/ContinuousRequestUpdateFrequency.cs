using System;
using System.Text.Json.Serialization;

namespace Navtor.Advisory.Models.Models.RouteOptimization.RequestProcessing
{
    public class ContinuousRequestUpdateFrequency
    {
        /// <summary>
        /// Continuous Request Update Frequency.
        /// </summary>
        public UpdateFrequencyType? Type { get; set; }

        /// <summary>
        /// Time range (Format: https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-timespan-format-strings#the-constant-c-format-specifier)
        /// </summary>
        [JsonConverter(typeof(JsonTimeSpanConverter))]
        public TimeSpan? TimeRange { get; set; } // https://stackoverflow.com/questions/59557138/system-text-jsonserializer-deserialization-of-timespan

        public UpdateFrequencyEventType? Event { get; set; }
    }
}
