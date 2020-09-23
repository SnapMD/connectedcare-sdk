using System;
using SnapMD.Web.Api.Models;
using System.Collections.Generic;

namespace SnapMD.VirtualCare.ApiModels
{
    /// <summary>
    /// The API uses JSON camel case serialization, so the variables supplied in the incoming request will have lower case.
    /// </summary>
    public class AddPatientProfileRequest
    {
        /// <summary>
        /// Get or set Create User Without Email
        /// </summary>
        /// <value>
        /// CreateUserWithoutEmail
        /// </value>
        public bool CreateUserWithoutEmail { get; set; }
        /// <summary>
        /// Get or set Email Address
        /// </summary>
        /// <value>
        /// EmailAddress
        /// </value>
        public string EmailAddress { get; set; }
        /// <summary>
        /// Get or set Patient Profile Data
        /// </summary>
        /// <value>
        /// Profile data of the patient
        /// </value>
        public PatientUpdateRequest PatientProfileData { get; set; }
        /// <summary>
        /// Get or set Patient MedicalHistory Data
        /// </summary>
        /// <value>
        /// Patient MedicalHistory Data
        /// </value>
        [Obsolete("Use MedicalHistoryProfile instead (except InfantData)")]
        public LegacyMedicalHistoryForm PatientMedicalHistoryData { get; set; }
        /// <summary>
        /// Get or set Medication Allergies
        /// </summary>
        /// <value>
        ///MedicationAllergies
        /// </value>
        [Obsolete("Use MedicalHistoryProfile instead")]
        public List<PatientAllergyItem> MedicationAllergies { get; set; }
        /// <summary>
        /// Current user medical profile  (except InfantData - will be used in a future).
        /// </summary>
        public MedicalHistoryProfile MedicalHistoryProfile { get; set; }
        /// <summary>
        /// Get or set Patient ProfileFields Tracing
        /// </summary>
        /// <value>
        ///PatientProfileFieldsTracing
        /// </value>
        public PatientProfileFieldChangesTrackingRequest PatientProfileFieldsTracing { get; set; }
        /// <summary>
        /// Get or set Time Zone Id
        /// </summary>
        /// <value>
        ///Time Zone Id
        /// </value>
        public int? TimeZoneId { get; set; }
        /// <summary>
        /// Get or set ImageId
        /// </summary>
        /// <value>
        ///ImageId
        /// </value>
        public Guid? ImageId { get; set; }
        /// <summary>
        /// If set to false the 'SyncPatientDataCommand' won't be called.
        /// </summary>
        public bool CallThirdParty { get; set; } = true;
    }

 
}