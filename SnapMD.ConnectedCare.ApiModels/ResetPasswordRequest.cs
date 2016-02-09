namespace SnapMD.ConnectedCare.ApiModels
{
    public class ResetPasswordRequest
    {
        public string Email { get; set; }
        public int HospitalId { get; set; }
        public bool? Admin { get; set; }
    }
}
