namespace SnapMD.VirtualCare.ApiModels
{
    /// <summary>
    /// Legacy interface for medications in the patient's medical history.
    /// </summary>
    public interface ILegacyMedicationAdapter
    {
        /// <summary>
        /// Gets or sets the taking medication1.
        /// </summary>
        /// <value>
        /// The taking medication1.
        /// </value>
        int? TakingMedication1 { get; set; }

        /// <summary>
        /// Gets or sets the taking medication2.
        /// </summary>
        /// <value>
        /// The taking medication2.
        /// </value>
        int? TakingMedication2 { get; set; }

        /// <summary>
        /// Gets or sets the taking medication3.
        /// </summary>
        /// <value>
        /// The taking medication3.
        /// </value>
        int? TakingMedication3 { get; set; }

        /// <summary>
        /// Gets or sets the taking medication4.
        /// </summary>
        /// <value>
        /// The taking medication4.
        /// </value>
        string TakingMedication4 { get; set; }
    }
}