namespace SnapMD.VirtualCare.ApiModels
{
    /// <summary>
    /// Legacy interface for patient medical history.
    /// </summary>
    /// <seealso cref="SnapMD.VirtualCare.ApiModels.ILegacySurgeryAdapter" />
    /// <seealso cref="SnapMD.VirtualCare.ApiModels.ILegacyAllergyAdapter" />
    /// <seealso cref="SnapMD.VirtualCare.ApiModels.ILegacyMedicationAdapter" />
    public interface ILegacyMedicalHistoryForm: ILegacySurgeryAdapter, ILegacyAllergyAdapter, ILegacyMedicationAdapter
    {
        /// <summary>
        /// Gets or sets the is child born full term.
        /// </summary>
        /// <value>
        /// The is child born full term.
        /// </value>
        string IsChildBornFullTerm { get; set; }

        /// <summary>
        /// Gets or sets the is child born vaginally.
        /// </summary>
        /// <value>
        /// The is child born vaginally.
        /// </value>
        string IsChildBornVaginally { get; set; }

        /// <summary>
        /// Gets or sets the is child discharge mother.
        /// </summary>
        /// <value>
        /// The is child discharge mother.
        /// </value>
        string IsChildDischargeMother { get; set; }

        /// <summary>
        /// Gets or sets the is one year below child.
        /// </summary>
        /// <value>
        /// The is one year below child.
        /// </value>
        string IsOneYearBelowChild { get; set; }

        /// <summary>
        /// Gets or sets the is vaccination up to date.
        /// </summary>
        /// <value>
        /// The is vaccination up to date.
        /// </value>
        string IsVaccinationUpToDate { get; set; }

        /// <summary>
        /// Gets or sets the medical condition1.
        /// </summary>
        /// <value>
        /// The medical condition1.
        /// </value>
        int? MedicalCondition1 { get; set; }

        /// <summary>
        /// Gets or sets the medical condition2.
        /// </summary>
        /// <value>
        /// The medical condition2.
        /// </value>
        int? MedicalCondition2 { get; set; }

        /// <summary>
        /// Gets or sets the medical condition3.
        /// </summary>
        /// <value>
        /// The medical condition3.
        /// </value>
        int? MedicalCondition3 { get; set; }

        /// <summary>
        /// Gets or sets the medical condition4.
        /// </summary>
        /// <value>
        /// The medical condition4.
        /// </value>
        int? MedicalCondition4 { get; set; }

        /// <summary>
        /// Gets or sets the patient identifier.
        /// </summary>
        /// <value>
        /// The patient identifier.
        /// </value>
        int PatientId { get; set; }
    }
}