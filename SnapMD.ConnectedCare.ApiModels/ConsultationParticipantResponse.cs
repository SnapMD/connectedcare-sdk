using System;

namespace SnapMD.ConnectedCare.ApiModels
{
    public class ConsultationParticipantResponse: ConsultationParticipantRequest
    {
        public Guid PersonId { get; set; }
    }
}
