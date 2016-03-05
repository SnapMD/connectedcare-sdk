using System;
using System.Collections.Generic;

namespace SnapMD.VirtualCare.ApiModels.Scheduling
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

        public List<AppointmentParticipantResponse> Participants { get; set; }
    }
}
