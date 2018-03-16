namespace SnapMD.VirtualCare.ApiModels
{
    /// <summary>
    ///     Items representing the person's identity.
    /// </summary>
    public class PatientPersonResponse
    {
        /// <summary>
        ///     Gets or sets the patient identifier.
        /// </summary>
        /// <value>
        ///     The patient identifier.
        /// </value>
        public int PatientId { get; set; }

        /// <summary>
        ///     Gets or sets the person.
        /// </summary>
        /// <value>
        ///     The person.
        /// </value>
        public PersonRecord Person { get; set; }
        
        /// <summary>
        ///     Gets or sets the hospital identifier.
        /// </summary>
        /// <value>
        ///     The hospital identifier.
        /// </value>
        public int ProviderId { get; set; }
        
        /// <summary>
        ///     Gets or sets the patient gender
        /// </summary>
        /// <value>
        ///     The patient gender
        /// </value>
        public string Gender { get; set; }

        /// <summary>
        /// Gets or sets the patient email.
        /// </summary>
        /// <value>
        ///     The patient email.
        /// </value>
        public string Email { get; set; }

        /// <summary>
        /// Patient's age human-readable representation
        /// </summary>
        public string AgeString { get; set; }

        /// <summary>
        /// Patient's address
        /// </summary>
        public AddressLocationObject Address { get; set; }

        /// <summary>
        /// Flag: patient info is included to a list, but that patient would be excluded by visibility rules.
        /// </summary>
        public bool IsInvisible { get; set; }

        /// <summary>
        /// Flag: providers for on demand consultations are available for this patient right now.
        /// </summary>
        public bool? OnDemandAvailable { get; set; }

    }
}
