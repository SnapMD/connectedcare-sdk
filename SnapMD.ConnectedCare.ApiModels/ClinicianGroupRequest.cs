namespace SnapMD.ConnectedCare.ApiModels
{
    public class ClinicianGroupRequest
    {
        public int? ClinicianId { get; set; }

        public int? GroupId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int HospitalId { get; set; }

        public GlobalStatusCode StatusCode { get; set; }

        public int? ParentGroupId { get; set; }
    }
}
