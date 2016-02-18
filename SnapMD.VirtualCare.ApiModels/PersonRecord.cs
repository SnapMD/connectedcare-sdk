using System;

namespace SnapMD.VirtualCare.ApiModels
{
    public class PersonRecord
    {
        public Guid Id { get; set; }

        public string NameSuffix { get; set; }
        public string NamePerfix { get; set; }
        public string FamilyName { get; set; }
        public string GivenName { get; set; }

        public int ProviderId { get; set; }
        public string PhotoUrl { get; set; }
        public byte[] PhotoContent { get; set; }
        public GlobalStatusCode StatusCode { get; set; }
    }
}
