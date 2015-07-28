using System.Collections.Generic;

namespace SnapMD.ConnectedCare.ApiModels
{
    public interface IMedicalHistoryProfile
    {
        List<CustomCode> MedicationAllergies { get; set; }
        List<SurgeryRecord> Surgeries { get; set; }
        List<CustomCode> MedicalConditions { get; set; }
        List<CustomCode> Medications { get; set; }
        NewbornRecord InfantData { get; set; }
    }
}