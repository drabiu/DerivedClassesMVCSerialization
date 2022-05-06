namespace Navtor.Advisory.Models.Models.RouteOptimization.Vessel
{
    /// <summary>
    /// Vessel Model to be used during route optimization
    /// </summary>
    public class VesselModel
    {
        /// <summary>
        /// Vessel's Displacement, tons
        /// </summary>
        public uint? Displacement { get; set; }

        /// <summary>
        /// Vessel Length, meters
        /// </summary>
        public double? Length { get; set; }

        /// <summary>
        /// Vessel beam, meters
        /// </summary>
        public double? Beam { get; set; }
    }
}