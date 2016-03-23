namespace SnapMD.VirtualCare.ApiModels.PermissionRules
{
    /// <summary>
    /// Response model for RegistrationAvailability
    /// </summary>
    /// <seealso cref="SnapMD.VirtualCare.ApiModels.PermissionRules.RegistrationAvailabilityRequest" />
    public class RegistrationAvailabilityResponse: RegistrationAvailabilityRequest
    {
        /// <summary>
        /// Gets or sets a value indicating whether this provider is available base on requested criteria.
        /// </summary>
        /// <value>
        /// <c>true</c> if this provider is available; otherwise, <c>false</c>.
        /// </value>
        public bool IsAvailable { get; set; }

        /// <summary>
        /// Gets or sets the message for result of processing the request.
        /// </summary>
        /// <value>
        /// The message.
        /// </value>
        public string Message { get; set; }
    }
}
