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

using System.Collections.Generic;

namespace SnapMD.VirtualCare.ApiModels
{
    /// <summary>
    ///     Patient medical history profile.
    /// </summary>
    public class PatientMedicalHistoryProfile : IPatientMedicalHistoryProfile, IMedicalHistoryProfile
    {
        /// <summary>
        ///     Default constructor.
        /// </summary>
        public PatientMedicalHistoryProfile()
        {
            MedicalConditions = new List<CustomCode>();
            InfantData = new NewbornRecord();
            MedicationAllergies = new List<CustomCode>();
            Surgeries = new List<SurgeryRecord>();
            Medications = new List<CustomCode>();
        }

        /// <summary>
        ///     Medical allergies.
        /// </summary>
        public List<CustomCode> MedicationAllergies { get; set; }

        /// <summary>
        ///     Patient surgeries.
        /// </summary>
        public List<SurgeryRecord> Surgeries { get; set; }

        /// <summary>
        ///     Patient medical conditions.
        /// </summary>
        public List<CustomCode> MedicalConditions { get; set; }

        /// <summary>
        ///     Medications.
        /// </summary>
        public List<CustomCode> Medications { get; set; }

        /// <summary>
        ///     Infra data.
        /// </summary>
        public NewbornRecord InfantData { get; set; }

        /// <summary>
        ///     Profile id.
        /// </summary>
        public int PatientId { get; set; }
    }
}
