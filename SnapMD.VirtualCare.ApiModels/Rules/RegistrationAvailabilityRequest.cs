namespace SnapMD.VirtualCare.ApiModels.Rules
{
    /// <summary>
    /// Request model for RegistrationAvailability
    /// </summary>
    public class RegistrationAvailabilityRequest : SubjectAddress, IRuleExecutionRequest
    {
        /// <summary>
        /// The category of the rule for the request.
        /// </summary>
        /// <value>
        /// The category.
        /// </value>
        public RuleCategoryCode Category => RuleCategoryCode.RegistrationAvailability;

        /// <summary>
        /// The hospital identifier for filtering the rules.
        /// </summary>
        /// <value>
        /// The hospital identifier.
        /// </value>
        public int HospitalId { get; set; }

        /// <summary>
        /// The geo location to be evaluated.
        /// </summary>
        /// <value>
        /// The geo location.
        /// </value>
        public GeoCoordinate GeoLocation { get; set; }

        /// <summary>
        /// The organization identifier to evaluated.
        /// </summary>
        /// <value>
        /// The organization identifier.
        /// </value>
        public int? OrganizationId { get; set; }

        /// <summary>
        /// The location identifier to evaluated.
        /// </summary>
        /// <value>
        /// The location identifier.
        /// </value>
        public int? LocationId { get; set; }

        /// <summary>
        /// A value indicating whether this <see cref="RegistrationAvailabilityRequest"/> is debug.
        /// Additional information maybe included in the response on debug.
        /// </summary>
        /// <value>
        ///   <c>true</c> if debug; otherwise, <c>false</c>.
        /// </value>
        public bool? Debug { get; set; }
    }
}
