using System;

namespace SnapMD.VirtualCare.ApiModels
{
    public class ConsultationParticipantResponse: ConsultationParticipantRequest
    {
        public Guid PersonId { get; set; }
    }
}
