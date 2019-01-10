using SnapMD.VirtualCare.ApiModels.Attributes;

namespace SnapMD.VirtualCare.ApiModels.Enums
{
    /// <summary>
    /// Standard usages for User Type.
    /// </summary>
    /// <remarks>
    /// Enum User Type 
    /// </remarks>
    [ModelName("ApiModels.UserType")]
    public enum UserType
    {
        /// <summary>
        ///  User type Unknown.
        /// </summary>
        /// <value>
        /// code is 0.
        /// </value>
        Unknown = 0,

        /// <summary>
        ///  User type Customer.
        /// </summary>
        /// <value>
        /// code is 1.
        /// </value>
        Customer = 1,

        /// <summary>
        ///  User type Clinician.
        /// </summary>
        /// <value>
        /// code is 2.
        /// </value>
        Clinician = 2,

        /// <summary>
        ///  User type Snap MDAdmin.
        /// </summary>
        /// <value>
        /// code is 3.
        /// </value>
        SnapMDAdmin = 3
    }
}
