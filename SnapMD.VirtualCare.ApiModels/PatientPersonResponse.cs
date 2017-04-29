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
    }
}
