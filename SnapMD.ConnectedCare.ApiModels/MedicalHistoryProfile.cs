using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SnapMD.ConnectedCare.ApiModels
{
    [XmlRoot("MedicalHistory", Namespace = "https://snap.md/api/v2/xml/medicalhistory")]
    public class MedicalHistoryProfile : IMedicalHistoryProfile
    {
        public List<CustomCode> MedicationAllergies { get; set; }

        public List<SurgeryRecord> Surgeries { get; set; }

        public List<CustomCode> MedicalConditions { get; set; }

        public List<CustomCode> Medications { get; set; }

        public NewbornRecord InfantData { get; set; }
    }
}