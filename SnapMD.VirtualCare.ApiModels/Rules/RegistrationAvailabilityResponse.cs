namespace SnapMD.VirtualCare.ApiModels.Rules
{
    /// <summary>
    /// Response model for RegistrationAvailability
    /// </summary>
    /// <seealso cref="SnapMD.VirtualCare.ApiModels.Rules.RegistrationAvailabilityRequest" />
    public class RegistrationAvailabilityResponse: RegistrationAvailabilityRequest
    {
        /// <summary>
        /// A value indicating whether this provider is available for registration base on requested criteria.
        /// </summary>
        /// <value>
        /// <c>true</c> if this provider is available; otherwise, <c>false</c>.
        /// </value>
        public bool IsAvailable { get; set; }

        /// <summary>
        /// The message for result of processing the request.
        /// </summary>
        /// <value>
        /// The message.
        /// </value>
        public string Message { get; set; }
    }
}
