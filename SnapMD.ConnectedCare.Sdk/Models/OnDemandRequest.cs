namespace SnapMD.ConnectedCare.Sdk.Models
{
    public class OnDemandRequest
    {
        public IntakeConcern[] Concerns { get; set; }
        public string Phone { get; set; }
        public int PatientId { get; set; }
    }
}