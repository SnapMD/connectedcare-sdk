namespace SnapMD.VirtualCare.ApiModels.Rules
{
    /// <summary>
    /// Request model for RegistrationAvailability
    /// </summary>
    public class RegistrationAvailabilityRequest : SubjectAddress
    {
        /// <summary>
        /// Gets or sets the geo location.
        /// </summary>
        /// <value>
        /// The geo location.
        /// </value>
        public GeoCoordinate GeoLocation { get; set; }

        /// <summary>
        /// Gets or sets the organization identifier.
        /// </summary>
        /// <value>
        /// The organization identifier.
        /// </value>
        public int? OrganizationId { get; set; }

        /// <summary>
        /// Gets or sets the location identifier.
        /// </summary>
        /// <value>
        /// The location identifier.
        /// </value>
        public int? LocationId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="RegistrationAvailabilityRequest"/> is debug.
        /// </summary>
        /// <value>
        ///   <c>true</c> if debug; otherwise, <c>false</c>.
        /// </value>
        public bool? Debug { get; set; }
    }
}
