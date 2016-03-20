namespace SnapMD.VirtualCare.ApiModels.Routing
{
    /// <summary>
    /// Response model for PatientRouting
    /// </summary>
    /// <seealso cref="SnapMD.VirtualCare.ApiModels.Routing.PatientRoutingRequest" />
    public class PatientRoutingResponse: PatientRoutingRequest
    {
        /// <summary>
        /// Gets or sets a value indicating whether this instance is service available.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is service available; otherwise, <c>false</c>.
        /// </value>
        public bool IsServiceAvailable { get; set; }

        /// <summary>
        /// Gets or sets the available provider ids.
        /// </summary>
        /// <value>
        /// The available provider ids.
        /// </value>
        public int[] AvailableProviderIds { get; set; }
    }
}
