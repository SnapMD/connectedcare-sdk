namespace SnapMD.VirtualCare.ApiModels
{
    /// <summary>
    /// Encapsultae GuardianRecord
    /// </summary>
    public class GuardianRecord
    {
        /// <summary>
        ///     Gets or sets the Patient Id.
        /// </summary>
        /// <value>
        ///     The Patient Id.
        /// </value>
        public int PatientId { get; set; }
        /// <summary>
        ///     Gets or sets the UserId.
        /// </summary>
        /// <value>
        ///     The UserId.
        /// </value>

        public int UserId { get; set; }
        /// <summary>
        ///     Gets or sets Address.
        /// </summary>
        /// <value>
        ///     The Guardian Address.
        /// </value>

        public string Address { get; set; }
        /// <summary>
        ///     Gets or sets HomePhone.
        /// </summary>
        /// <value>
        ///     The HomePhone.
        /// </value>

        public string HomePhone { get; set; }
        /// <summary>
        ///     Gets or sets MobilePhone.
        /// </summary>
        /// <value>
        ///     The MobilePhone.
        /// </value>
        public string MobilePhone { get; set; }
        /// <summary>
        ///     Gets or sets FirstName.
        /// </summary>
        /// <value>
        ///     The FirstName.
        /// </value>
        public string FirstName { get; set; }
        /// <summary>
        ///     Gets or sets LastName.
        /// </summary>
        /// <value>
        ///     The LastName.
        /// </value>
        public string LastName { get; set; }
    }
}
