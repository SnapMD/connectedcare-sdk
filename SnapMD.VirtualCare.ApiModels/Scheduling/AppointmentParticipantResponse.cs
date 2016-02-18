using System;

namespace SnapMD.VirtualCare.ApiModels.Scheduling
{
    namespace SnapMD.Core.Models.Scheduling
    {
        /// <summary>
        ///     Request type for appointment participants.
        /// </summary>
        public class AppointmentParticipantResponse : AppointmentParticipantRequest
        {
            public Guid ParticipantId { get; set; }
            
            public virtual GlobalStatusCode Status { get; set; }
        }
    }
}
