namespace SnapMD.VirtualCare.ApiModels
{
    public class PatientsGroupRequest
    {
        public int[] PatientsIds { get; set; }

        public int? GroupId { get; set; }
        public int[] GroupsIds { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public GlobalStatusCode? StatusCode { get; set; }

        public int? ParentGroupId { get; set; }
    }
}
