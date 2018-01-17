using System;
namespace SnapMD.VirtualCare.ApiModels
{
    public class PatientsGroupResponse: PatientsGroupRequest
    {
        public int? PatientId { get; set; }

        public int? HospitalId { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public PatientsGroupResponse[] SubGroups { get; set; }

        public PatientProfilesResult[] Members { get; set; }
    }
}
