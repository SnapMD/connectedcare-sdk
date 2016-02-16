using System;

namespace SnapMD.ConnectedCare.ApiModels.Scheduling
{
    /// <summary>
    /// Appointment response model.
    /// </summary>
    public class AppointmentResponse : AppointmentRequest
    {
        /// <summary>
        /// Appointment id.
        /// </summary>
        public Guid AppointmentId { get; set; }

        /// <summary>
        /// Appointment status.
        /// </summary>
        public AppointmentStatusCode AppointmentStatusCode { get; set; }
    }
}
