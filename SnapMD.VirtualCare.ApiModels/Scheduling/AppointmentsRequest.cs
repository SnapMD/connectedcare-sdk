using System.Collections.Generic;

namespace SnapMD.VirtualCare.ApiModels.Scheduling
{
    /// <summary>
    /// Request model for Appointments search filter 
    /// </summary>
    /// <seealso cref="SnapMD.VirtualCare.ApiModels.Scheduling.AvailabilityBlocksRequest" />
    public class AppointmentsRequest : AvailabilityBlocksRequest
    {
        /// <summary>
        /// Gets or sets the appointment status codes.
        /// </summary>
        /// <value>
        /// The appointment status codes.
        /// </value>
        public AppointmentStatusCode[] AppointmentStatusCodes { get; set; }
    }
}
