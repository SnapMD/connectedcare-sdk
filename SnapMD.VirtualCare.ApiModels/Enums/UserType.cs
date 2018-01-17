using SnapMD.VirtualCare.ApiModels.Attributes;

namespace SnapMD.VirtualCare.ApiModels.Enums
{
    [ModelName("ApiModels.UserType")]
    public enum UserType
    {
        Unknown = 0,
        Customer = 1,
        Clinician = 2,
        SnapMDAdmin = 3
    }
}
