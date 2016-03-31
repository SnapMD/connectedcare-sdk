using System;
namespace SnapMD.VirtualCare.ApiModels
{
    public class ClinicianGroupResponse: ClinicianGroupRequest
    {
        public int? ClinicianId { get; set; }

        public int? HospitalId { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public ClinicianGroupResponse[] SubGroups { get; set; }

        public ClinicianProfilesResult[] Members { get; set; }
    }
}
