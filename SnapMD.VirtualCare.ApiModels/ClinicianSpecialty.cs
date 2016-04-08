namespace SnapMD.VirtualCare.ApiModels
{
    /// <summary>
    ///     Represents a clinician's area of expertise.
    /// </summary>
    public class ClinicianSpecialty
    {
        /// <summary>
        ///     Gets or sets the primary specialty.
        /// </summary>
        /// <value>
        ///     The primary.
        /// </value>
        public string Primary { get; set; }

        /// <summary>
        ///     Gets or sets the secondary specialty.
        /// </summary>
        /// <value>
        ///     The secondary.
        /// </value>
        public string Secondary { get; set; }
    }
}