namespace SnapMD.VirtualCare.ApiModels.Scheduling
{
    /// <summary>
    /// Response Model for OnDemandAvailability
    /// </summary>
    /// <seealso cref="SnapMD.VirtualCare.ApiModels.Scheduling.OnDemandAvailabilityRequest" />
    public class OnDemandAvailabilityResponse : OnDemandAvailabilityRequest
    {
        /// <summary>
        /// Gets or sets a value indicating whether [provider has ondemand enabled].
        /// </summary>
        /// <value>
        /// <c>true</c> if [provider has ondemand enabled]; otherwise, <c>false</c>.
        /// </value>
        public bool ProviderOnDemandEnabled { get; set; }

        /// <summary>
        /// Gets or sets the count of ondemand availability blocks at the moment.
        /// </summary>
        /// <value>
        /// The count of ondemand availability blocks at the moment.
        /// </value>
        public int OnDemandAvailabilityBlockCount { get; set; }
    }
}
