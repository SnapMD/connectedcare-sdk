using System;

namespace SnapMD.VirtualCare.ApiModels
{
    /// <summary>
    /// Return person api.
    /// </summary>
    public class LegacyMedicalHistoryForm
    {
        /// <summary>
        /// Gets or sets the Medication 1.
        /// </summary>
        /// <value>
        /// Allergic Medication.
        /// </value>
        [Obsolete("Use List<PatientAllergyItem> in parent datastructure instead")]
        public int? AllergicMedication1 { get; set; }

        /// <summary>
        /// Gets or sets the Medication 2.
        /// </summary>
        /// <value>
        /// Allergic Medication.
        /// </value>
        [Obsolete("Use List<PatientAllergyItem> in parent datastructure instead")]
        public int? AllergicMedication2 { get; set; }

        /// <summary>
        /// Gets or sets the Medication 3.
        /// </summary>
        /// <value>
        /// Allergic Medication.
        /// </value>

        [Obsolete("Use List<PatientAllergyItem> in parent datastructure instead")]
        public int? AllergicMedication3 { get; set; }

        /// <summary>
        /// Gets or sets the Medication 3.
        /// </summary>
        /// <value>
        /// Allergic Medication.
        /// </value>
        [Obsolete("Use List<PatientAllergyItem> in parent datastructure instead")]
        public int? AllergicMedication4 { get; set; }

        /// <summary>
        /// Gets or sets  the Child Born Full Term.
        /// </summary>
        /// <value>
        ///  Child Born Full Term.
        /// </value>
        public string IsChildBornFullTerm { get; set; }

        /// <summary>
        /// Gets or sets  the Child Born Vaginally.
        /// </summary>
        /// <value>
        ///  Child Born Vaginally.
        /// </value>
        public string IsChildBornVaginally { get; set; }

        /// <summary>
        /// Gets or sets  the Child Discharge mother.
        /// </summary>
        /// <value>
        ///  Child Discharge mother.
        /// </value>
        public string IsChildDischargeMother { get; set; }

        /// <summary>
        /// Gets or sets  the Child Discharge mother.
        /// </summary>
        /// <value>
        ///  Child Discharge mother.
        /// </value>
        public string IsOneYearBelowChild { get; set; }

        /// <summary>
        /// Gets or sets  the Vaccination UP Date.
        /// </summary>
        /// <value>
        /// Vaccination UP Date.
        /// </value>
        public string IsVaccinationUpToDate { get; set; }

        /// <summary>
        /// Gets or sets  the Medical Condition.
        /// </summary>
        /// <value>
        /// Medical Condition.
        /// </value>
        public int? MedicalCondition1 { get; set; }

        /// <summary>
        /// Gets or sets is the Medical Condition 2.
        /// </summary>
        /// <value>
        /// Medical Condition.
        /// </value>
        public int? MedicalCondition2 { get; set; }

        /// <summary>
        /// Gets or sets  the Medical Condition 3.
        /// </summary>
        /// <value>
        /// Medical Condition.
        /// </value>
        public int? MedicalCondition3 { get; set; }

        /// <summary>
        /// Gets or sets  the Medical Condition 4.
        /// </summary>
        /// <value>
        /// Medical Condition.
        /// </value>
        public int? MedicalCondition4 { get; set; }

        /// <summary>
        /// Gets or sets  the Patient Id.
        /// </summary>
        /// <value>
        /// Patient Id.
        /// </value>
        public int PatientId { get; set; }

        /// <summary>
        /// Gets or sets  the Prior Surgery 1.
        /// </summary>
        /// <value>
        ///Prior Surgery 1.
        /// </value>
        public string PriorSurgery1 { get; set; }

        /// <summary>
        /// Gets or sets  the Prior Surgery 2.
        /// </summary>
        /// <value>
        ///Prior Surgery 2.
        /// </value>
        public string PriorSurgery2 { get; set; }

        /// <summary>
        /// Gets or sets  the Prior Surgery 3.
        /// </summary>
        /// <value>
        ///Prior Surgery 3.
        /// </value>
        public string PriorSurgery3 { get; set; }

        /// <summary>
        /// Gets or sets  the  Surgery Month 1.
        /// </summary>
        /// <value>
        ///Prior Surgery Month 1.
        /// </value>
        public int? Surgery1Month { get; set; }

        /// <summary>
        /// Gets or sets  the  Surgery Year 1.
        /// </summary>
        /// <value>
        ///Surgery Year 1.
        /// </value>
        public int? Surgery1Year { get; set; }

        /// <summary>
        /// Gets or sets  the  Surgery Month 3.
        /// </summary>
        /// <value>
        ///Surgery Month 3.
        /// </value>
        public int? Surgery2Month { get; set; }

        /// <summary>
        /// Gets or sets  the  Surgery Year 2.
        /// </summary>
        /// <value>
        ///Surgery Year 2.
        /// </value>
        public int? Surgery2Year { get; set; }

        /// <summary>
        /// Gets or sets  the  Surgery Month 3.
        /// </summary>
        /// <value>
        ///Surgery Month 3.
        /// </value>
        public int? Surgery3Month { get; set; }

        /// <summary>
        /// Gets or sets  the  Surgery Year 3.
        /// </summary>
        /// <value>
        ///Prior Surgery Year 3.
        /// </value>
        public int? Surgery3Year { get; set; }

        /// <summary>
        /// Gets or sets  the  Medication 1.
        /// </summary>
        /// <value>
        ///Taking  Medication 1.
        /// </value>
        public int? TakingMedication1 { get; set; }


        /// <summary>
        /// Gets or sets  the  Medication 2.
        /// </summary>
        /// <value>
        ///Taking  Medication 2.
        /// </value>
        public int? TakingMedication2 { get; set; }

        /// <summary>
        /// Gets or sets  the  Medication 3.
        /// </summary>
        /// <value>
        ///Taking  Medication 3.
        /// </value>
        public int? TakingMedication3 { get; set; }

        /// <summary>
        /// Gets or sets  the  Medication 4.
        /// </summary>
        /// <value>
        ///Taking  Medication 4.
        /// </value>
        public string TakingMedication4 { get; set; }
    }
}
