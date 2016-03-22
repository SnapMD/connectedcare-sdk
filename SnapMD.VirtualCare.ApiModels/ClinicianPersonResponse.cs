namespace SnapMD.VirtualCare.ApiModels
{
    /// <summary>
    ///     Items representing the person's identity.
    /// </summary>
    public class ClinicianPersonResponse
    {
        /// <summary>
        ///     Gets or sets the user identifier.
        /// </summary>
        /// <value>
        ///     The user identifier.
        /// </value>
        public int UserId { get; set; }

        /// <summary>
        ///     Gets or sets the person.
        /// </summary>
        /// <value>
        ///     The person.
        /// </value>
        public PersonRecord Person { get; set; }
        
        /// <summary>
        ///     Gets or sets the provider identifier.
        /// </summary>
        /// <value>
        ///     The provider identifier.
        /// </value>
        public int ProviderId { get; set; }
    }
}
