﻿#region Copyright
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
using System.Collections.Generic;
using System.Xml.Serialization;

namespace SnapMD.VirtualCare.ApiModels
{
    /// <summary>
    /// Represent IPatient Admin Api.
    /// </summary>
    [XmlRoot("MedicalHistory", Namespace = "https://snap.md/api/v2/xml/medicalhistory")]
    public class MedicalHistoryProfile : IMedicalHistoryProfile
    {
        /// <summary>
        ///  Get and Set Medication Allergies.
        /// </summary>
        [XmlArrayItem("CustomCode", typeof(LegacyPatientAllergyItem))]
        [XmlArrayItem("PatientAllergy", typeof(PatientAllergyItem))]
        public List<PatientAllergyItem> MedicationAllergies { get; set; }
        /// <summary>
        ///  Get and Set Surgeries.
        /// </summary>
        public List<SurgeryRecord> Surgeries { get; set; }
        /// <summary>
        ///  Get and Set Medical Conditions.
        /// </summary>
        public List<CustomCode> MedicalConditions { get; set; }
        /// <summary>
        ///  Get and Set Medications.
        /// </summary>
        public List<CustomCode> Medications { get; set; }
        /// <summary>
        ///  Get and Set InfantData.
        /// </summary>
        public NewbornRecord InfantData { get; set; }
    }
}