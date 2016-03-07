namespace SnapMD.VirtualCare.ApiModels
{
    /// <summary>
    /// Contains information about Staff Acount.
    /// </summary>
    public class StaffAccountModelRequest
    {
        /// <summary>
        /// General user information.
        /// All staffs (doctors and not doctors) must have this info.
        /// </summary>
        public UserDetailsRequest UserDetails { get; set; }

        /// <summary>
        /// Public information about doctor. 
        /// This information required only for staff who has doctor roles.
        /// </summary>
        public StaffProfileDetailsRequest DoctorProfileDetailsRequest { get; set; }


        /// <summary>
        /// User roles.
        /// Each user must have at least one role.
        /// </summary>
        public UserRole[] Roles { get; set; }

        /// <summary>
        /// Tags.
        /// This is an optional parameter. 
        /// </summary>
        public string Tags { get; set; }
    }

}