using System;

namespace SnapMD.ConnectedCare.ApiModels
{
    public class FamilyMember
    {
        public int PatientId { get; set; }
        public string PatientName { get; set; }
        public string ProfileImagePath { get; set; }
        public int RelationCode { get; set; }
        public bool IsAuthorized { get; set; }
        public DateTime? Birthdate { get; set; }
        public string[] Addresses { get; set; }
        public string PatientFirstName { get; set; }
        public string PatientLastName { get; set; }
        public string GuardianFirstName { get; set; }
        public string GuardianLastName { get; set; }
        public string GuardianName { get; set; }
    }
}
