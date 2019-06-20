#region Copyright
//    Copyright 2016 SnapMD, Inc.
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
//        http://www.apache.org/licenses/LICENSE-2.0
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.
#endregion
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace SnapMD.VirtualCare.ApiModels
{
    /// <summary>
    /// Encapsulate the Medical History profil data .
    /// </summary>
    [XmlRoot("MedicalHistory", Namespace = "https://snap.md/api/v2/xml/medicalhistory")]
    public class MedicalHistoryProfile : IMedicalHistoryProfile
    {
        /// <summary>
        /// Gets or sets the MedicationAllergies.
        /// </summary>
        /// <value>
        /// Allergic Medication.
        /// </value>
        [XmlArrayItem("CustomCode", typeof(LegacyPatientAllergyItem))]
        [XmlArrayItem("PatientAllergy", typeof(PatientAllergyItem))]
        [JsonProperty("medicationAllergies")]
        public List<PatientAllergyItem> MedicationAllergies { get; set; }

        /// <summary>
        /// Gets or sets the Surgeries.
        /// </summary>
        /// <value>
        /// Surgeries Record.
        /// </value>
        [JsonProperty("surgeries")]
        public List<SurgeryRecord> Surgeries { get; set; }

        /// <summary>
        /// Gets or sets the medical conditions.
        /// </summary>
        /// <value>
        /// Medical Conditions Record.
        /// </value>
        [JsonProperty("medicalConditions")]
        public List<CustomCode> MedicalConditions { get; set; }

        /// <summary>
        /// Gets or sets the Medications.
        /// </summary>
        /// <value>
        /// Medications Record.
        /// </value>
        [JsonProperty("medications")]
        public List<CustomCode> Medications { get; set; }

        /// <summary>
        /// Gets or sets the Infant Data.
        /// </summary>
        /// <value>
        /// InfantData Record.
        /// </value>
        [JsonProperty("infantData")]
        public NewbornRecord InfantData { get; set; }
    }
}