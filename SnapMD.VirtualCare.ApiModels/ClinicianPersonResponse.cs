namespace SnapMD.VirtualCare.ApiModels
{
    /// <summary>
    ///     Items representing the person's identity.
    /// </summary>
    public class ClinicianPersonResponse
    {
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
        ///     Gets or sets the department.
        /// </summary>
        /// <value>
        ///     The department.
        /// </value>
        public string Department { get; set; }

        /// <summary>
        ///     Gets or sets the specialty.
        /// </summary>
        /// <value>
        ///     The specialty.
        /// </value>
        public ClinicianSpecialty Specialty { get; set; } = new ClinicianSpecialty();

        /// <summary>
        ///     Gets or sets the user identifier.
        /// </summary>
        /// <value>
        ///     The user identifier.
        /// </value>
        public int UserId { get; set; }

        /// <summary>
        /// Person's email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Person's status online|offline
        /// </summary>
        public string Presence { get; set; }
        
        /// <summary>
        /// Shows if Provider have Coduct consultation permission.
        /// </summary>
        public bool CanHaveConsultation { get; set; }
        
        /// <summary>
        /// Staff profile gender.
        /// </summary>
        public string Gender { get; set; }
    }
}
