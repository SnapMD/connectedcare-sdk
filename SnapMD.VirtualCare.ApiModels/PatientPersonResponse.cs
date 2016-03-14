namespace SnapMD.VirtualCare.ApiModels
{
    /// <summary>
    /// Items representing the person's identity.
    /// </summary>
    public class PatientPersonResponse
    {
        /// <summary>
        /// Gets or sets the patient identifier.
        /// </summary>
        /// <value>
        /// The patient identifier.
        /// </value>
        public int PatientId { get; set; }
        /// <summary>
        /// Gets or sets the provider identifier.
        /// </summary>
        /// <value>
        /// The provider identifier.
        /// </value>
        public int ProviderId { get; set; }
        /// <summary>
        /// Gets or sets the person.
        /// </summary>
        /// <value>
        /// The person.
        /// </value>
        public PersonRecord Person { get; set; }
    }
}