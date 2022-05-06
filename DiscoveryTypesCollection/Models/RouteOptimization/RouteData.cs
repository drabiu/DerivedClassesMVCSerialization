using System;

namespace Navtor.Advisory.Models.Models.RouteOptimization
{
    public class RouteData
    {
        public string? Format { get; set; }

        /// <summary>
        /// Raw Route Data
        /// </summary>
        public byte[] Data { get; set; } = Array.Empty<byte>();
    }
}