namespace SnapMD.VirtualCare.ApiModels
{
    /// <summary>
    /// 
    /// </summary>
    public class UserDetailsRequest
    {
        /// <summary>
        /// User First name.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// User Last name.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// User Email.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// User phone number.
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// User cell phone number.
        /// </summary>
        public string CellPhoneNumber { get; set; }

        /// <summary>
        /// User time zone Id.
        /// Use TimeZoneId = 83 for Pacific Standard Time.
        /// </summary>
        public int? TimeZoneId { get; set; }

        /// <summary>
        /// Path to doctor profile image in SnapMD system.
        /// In third party tool you will usually keep this field empty, so user will be able add his photo when he will be activated.
        /// As default you can use "/images/Doctor-Male.gif" and "/images/Doctor-Female.gif" 
        /// </summary>
        public string ProfileImage { get; set; }

        /// <summary>
        /// Specify, whether user will receive alerts or not.
        /// Current DB structure require this field for all users (physicians and non physicians).
        /// </summary>
        public bool ReceiveTextAlerts { get; set; }
    }
}
