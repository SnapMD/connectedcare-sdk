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

using System.Collections.Generic;

namespace SnapMD.VirtualCare.ApiModels
{
    /// <summary>
    /// Represent IIntake Questionnaire.
    /// </summary>
    public interface IIntakeQuestionnaire : IMedicalHistoryProfile
    {
        /// <summary>
        ///     Gets or sets the Concerns.
        /// </summary>
        /// <value>
        ///  List of EncounterConcern.
        /// </value>
        List<EncounterConcern> Concerns { get; set; }

        /// <summary>
        ///     Gets or sets the PatientRecord.
        /// </summary>
        /// <value>
        /// PatientRecord.
        /// </value>
        PatientRecord PatientRecord { get; set; }
        /// <summary>
        ///     Gets or sets the DoctorRecord.
        /// </summary>
        /// <value>
        /// DoctorRecord.
        /// </value>
        DoctorRecord DoctorRecord { get; set; }
        /// <summary>
        ///     Gets or sets the HospitalRecord.
        /// </summary>
        /// <value>
        /// HospitalRecord.
        /// </value>
        HospitalRecord HospitalRecord { get; set; }
        /// <summary>
        ///     Gets or sets the GuardiansRecords.
        /// </summary>
        /// <value>
        /// GuardiansRecords.
        /// </value>
        List<GuardianRecord> GuardiansRecords { get; set; }
        /// <summary>
        ///     Gets or sets the AdditionalNotes.
        /// </summary>
        /// <value>
        /// AdditionalNotes.
        /// </value>
        string AdditionalNotes { get; set; }
    }
}
