using System;

namespace SnapMD.VirtualCare.ApiModels
{
    /// <summary>
    /// Legacy model to represent patient's medical history as entered in the patient's profile.
    /// </summary>
    /// <seealso cref="SnapMD.VirtualCare.ApiModels.ILegacyMedicalHistoryForm" />
    [Obsolete("Please use the MedicalHistoryProfile class")]
    public class LegacyMedicalHistoryForm : ILegacyMedicalHistoryForm
    {
        public int? AllergicMedication1 { get; set; }

        public int? AllergicMedication2 { get; set; }

        public int? AllergicMedication3 { get; set; }

        public int? AllergicMedication4 { get; set; }

        public string IsChildBornFullTerm { get; set; }

        public string IsChildBornVaginally { get; set; }

        public string IsChildDischargeMother { get; set; }

        public string IsOneYearBelowChild { get; set; }

        public string IsVaccinationUpToDate { get; set; }

        public int? MedicalCondition1 { get; set; }

        public int? MedicalCondition2 { get; set; }

        public int? MedicalCondition3 { get; set; }

        public int? MedicalCondition4 { get; set; }

        public int PatientId { get; set; }

        public string PriorSurgery1 { get; set; }

        public string PriorSurgery2 { get; set; }

        public string PriorSurgery3 { get; set; }

        public int? Surgery1Month { get; set; }

        public int? Surgery1Year { get; set; }

        public int? Surgery2Month { get; set; }

        public int? Surgery2Year { get; set; }

        public int? Surgery3Month { get; set; }

        public int? Surgery3Year { get; set; }

        public int? TakingMedication1 { get; set; }

        public int? TakingMedication2 { get; set; }

        public int? TakingMedication3 { get; set; }

        public string TakingMedication4 { get; set; }
    }
}
