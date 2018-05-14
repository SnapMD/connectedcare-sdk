﻿using System;
using SnapMD.Web.Api.Models;
using System.Collections.Generic;

namespace SnapMD.VirtualCare.ApiModels
{
    /// <summary>
    /// The API uses JSON camel case serialization, so the variables supplied in the incoming request will have lower case.
    /// </summary>
    public class AddPatientProfileRequest
    {
        public bool CreateUserWithoutEmail { get; set; }
        public string EmailAddress { get; set; }
        public PatientUpdateRequest PatientProfileData { get; set; }
        public LegacyMedicalHistoryForm PatientMedicalHistoryData { get; set; }
        public List<PatientAllergyItem> MedicationAllergies { get; set; }
        public PatientProfileFieldChangesTrackingRequest PatientProfileFieldsTracing { get; set; }
        public int? TimeZoneId { get; set; }
        public Guid? ImageId { get; set; }
    }

 
}