using System;

namespace SnapMD.VirtualCare.ApiModels
{
    public class ConsultationParticipantResponse: ConsultationParticipantRequest
    {
        public Guid PersonId { get; set; }
        
        /// <summary>
        /// The id of consultation meeting (chat)
        /// </summary>
        public Guid? MeetingId { get; set; }
    }
}
