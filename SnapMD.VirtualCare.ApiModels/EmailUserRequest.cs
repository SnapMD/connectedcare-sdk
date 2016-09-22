using SnapMD.VirtualCare.ApiModels.Enums;

namespace SnapMD.VirtualCare.ApiModels
{
    /// <summary>
    /// Request Model for sending email to user. 
    /// </summary>
    public class EmailUserRequest
    {
        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>
        /// The email.
        /// </value>
        public string Email { get; set; }
        /// <summary>
        /// Gets or sets the hospital identifier.
        /// </summary>
        /// <value>
        /// The hospital identifier.
        /// </value>
        public int HospitalId { get; set; }
        /// <summary>
        /// Gets or sets the user type identifier.
        /// </summary>
        /// <value>
        /// The user type identifier.
        /// </value>
        public UserType? UserTypeId { get; set; }

        /// <summary>
        /// The token for the email request.
        /// </summary>
        public string Token { get; set; }
    }
}
