using System;

namespace SnapMD.ConnectedCare.ApiModels.Scheduling
{
    namespace SnapMD.Core.Models.Scheduling
    {
        /// <summary>
        ///     Request type for appointment participants.
        /// </summary>
        public class AppointmentParticipantRequest
        {
            public Guid AppointmentId { get; set; }

            public AttendenceCode AttendenceCode { get; set; }
            
            public string ReferenceType => @"AppointmentParticipantRequest";

            public PersonRecord Person { get; set; }

            public ParticipantTypeCode ParticipantTypeCode { get; set; }
            
        }
    }
}
