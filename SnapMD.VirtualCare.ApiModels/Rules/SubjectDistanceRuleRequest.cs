namespace SnapMD.VirtualCare.ApiModels.Rules
{
    /// <summary>
    /// Request model for SubjectDistance
    /// </summary>
    /// <seealso cref="RuleRequest" />
    public class SubjectDistanceRuleRequest : RuleRequest
    {
        /// <summary>
        /// The center, the geo location to be referenced.
        /// </summary>
        /// <value>
        /// The center.
        /// </value>
        public GeoCoordinate Center { get; set; }

        /// <summary>
        /// The distance from the center.
        /// </summary>
        /// <value>
        /// The distance.
        /// </value>
        public decimal? Distance { get; set; }

        /// <summary>
        /// The unit for distance calculation.
        /// </summary>
        /// <value>
        /// The distance unit.
        /// </value>
        public GeoDistanceUnit? DistanceUnit { get; set; }
    }
}
