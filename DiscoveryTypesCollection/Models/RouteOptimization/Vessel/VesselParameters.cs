namespace Navtor.Advisory.Models.Models.RouteOptimization.Vessel
{
    /// <summary>
    /// Vessel Parameters for Route Optimization Request
    /// </summary>
    public class VesselParameters
    {
        public VesselLoadingConditionType? LoadingCondition { get; set; }

        /// <summary>
        /// Vessel's Cargo, tons
        /// </summary>
        public uint? Cargo { get; set; }

        /// <summary>
        /// Draught Forward (bow), meters
        /// </summary>
        public double? DraughtFwd { get; set; }

        /// <summary>
        /// Draught Aft (Stern), meters
        /// </summary>
        public double? DraughtAft { get; set; }

        /// <summary>
        /// Metacentric height of the vessel for intended voyage, meters
        /// </summary>
        public uint? Gm { get; set; }

        /// <summary>
        /// Vessel’s max roll angle allowed, degrees
        /// </summary>
        public uint? MaxRoll { get; set; }

        /// <summary>
        /// Vessel’s significant wave height limit, meters
        /// </summary>
        public double? MaxWaveHeight { get; set; }

        /// <summary>
        /// Vessel’s max wind speed limit, meters per second
        /// </summary>
        public double? MaxWindSpeed { get; set; }

        /// <summary>
        /// Vessel’s max speed, knots
        /// </summary>
        public double? SpeedMax { get; set; }

        /// <summary>
        /// Vessel’s service speed min
        /// </summary>
        public double? ServiceSpeedMin { get; set; }

        /// <summary>
        /// Vessel’s service speed max
        /// </summary>
        public double? ServiceSpeedMax { get; set; }

        /// <summary>
        /// Vessel's service speed RPM min
        /// </summary>
        public uint? ServiceRpmMin { get; set; }

        /// <summary>
        /// Vessel's service speed RPM max
        /// </summary>
        public uint? ServiceRpmMax { get; set; }

        public FuelParameters? FuelParameters { get; set; }
    }
}