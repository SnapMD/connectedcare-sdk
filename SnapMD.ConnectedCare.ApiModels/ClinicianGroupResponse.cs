using System;
namespace SnapMD.ConnectedCare.ApiModels
{
    public class ClinicianGroupResponse: ClinicianGroupRequest
    {
        public int HospitalId { get; set; }

        public DateTime ModifiedDate { get; set; }
    }
}
