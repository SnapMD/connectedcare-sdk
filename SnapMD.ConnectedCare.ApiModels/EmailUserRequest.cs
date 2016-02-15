using SnapMD.ConnectedCare.ApiModels.Enums;

namespace SnapMD.ConnectedCare.ApiModels
{
    public class EmailUserRequest
    {
        public string Email { get; set; }
        public int HospitalId { get; set; }
        public UserType? UserTypeId { get; set; }
    }
}
