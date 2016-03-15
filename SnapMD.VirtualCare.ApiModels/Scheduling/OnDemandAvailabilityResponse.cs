namespace SnapMD.VirtualCare.ApiModels.Scheduling
{
    /// <summary>
    /// Response Model for OnDemandAvailability
    /// </summary>
    /// <seealso cref="SnapMD.VirtualCare.ApiModels.Scheduling.OnDemandAvailabilityRequest" />
    public class OnDemandAvailabilityResponse : OnDemandAvailabilityRequest
    {
        /// <summary>
        /// Gets or sets a value indicating whether [provider on demand].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [provider on demand]; otherwise, <c>false</c>.
        /// </value>
        public bool ProviderOnDemand { get; set; }

        /// <summary>
        /// Gets or sets the on demand availability.
        /// </summary>
        /// <value>
        /// The on demand availability.
        /// </value>
        public int OnDemandAvailability { get; set; }
    }
}
