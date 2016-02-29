namespace SnapMD.VirtualCare.ApiModels
{
    /// <summary>
    /// Response model for user activation.
    /// </summary>
    /// <seealso cref="SnapMD.VirtualCare.ApiModels.UserActivationRequest" />
    public class UserActivationResponse: UserActivationRequest
    {
        /// <summary>
        /// Gets or sets the user identifier.
        /// </summary>
        /// <value>
        /// The user identifier.
        /// </value>
        public int UserID { get; set; }
    }
}
