using System;

namespace SnapMD.VirtualCare.ApiModels
{
    public class ConsultationParticipantRequest
    {
        public Guid? ParticipantId { get; set; }
        public int? ParticipantType { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string PhotoUrl { get; set; }
        public byte[] PhotoContent { get; set; }
    }
}
