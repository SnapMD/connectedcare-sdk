using System;

namespace SnapMD.VirtualCare.ApiModels.Scheduling
{
    /// <summary>
    /// Request Model for OnDemandAvailability
    /// </summary>
    public class OnDemandAvailabilityRequest
    {
        /// <summary>
        /// The hospital identifier (default to login user's providerId) for the request.
        /// </summary>
        /// <value>
        /// The hospital identifier.
        /// </value>
        public int? ProviderId { get; set; }

        /// <summary>
        /// The start time of the OnDemand request (default to Now).
        /// </summary>
        /// <value>
        /// The start time.
        /// </value>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// The end time of the OnDemand request (default to Now + MinAppointmentLength).
        /// </summary>
        /// <value>
        /// The end time.
        /// </value>
        public DateTime? EndTime { get; set; }
    }
}
