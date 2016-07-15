using System;

namespace SnapMD.VirtualCare.ApiModels.Scheduling
{
    /// <summary>
    /// Appointment creation request model.
    /// </summary>
    public class EditAppointmentRequest : NewAppointmentRequest
    {
        /// <summary>
        /// The ID of the appointment.
        /// </summary>
        public Guid? AppointmentId { get; set; }
    }
}
