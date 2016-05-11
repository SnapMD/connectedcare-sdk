using System;

namespace SnapMD.VirtualCare.ApiModels.Scheduling
{
    /// <summary>
    ///     Request type for appointment participants.
    /// </summary>
    public class AppointmentParticipantRequest
    {
        /// <summary>
        ///     Attendence type.
        /// </summary>
        public AttendenceCode AttendenceCode { get; set; }

        /// <summary>
        ///     Participant person id.
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        ///     Participant type.
        /// </summary>
        public ParticipantTypeCode ParticipantTypeCode { get; set; }
    }
}
