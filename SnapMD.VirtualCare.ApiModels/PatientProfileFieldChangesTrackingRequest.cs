using System;

namespace SnapMD.Web.Api.Models
{
    /// <summary>
    /// Represents the Patient Profile Field Changes Trac king Request.
    /// </summary>
    public class PatientProfileFieldChangesTrackingRequest
    {
        /// <summary>
        /// Get or set the patient Address
        /// </summary>
        /// <value>
        /// patient Address
        /// </value>
        public bool? Address { get; set; }

        /// <summary>
        /// Get or set the patient Blood Type
        /// </summary>
        /// <value>
        /// patient Blood Type
        /// </value>
        public bool? BloodType { get; set; }

        /// <summary>
        /// Get or set the City
        /// </summary>
        /// <value>
        /// patient City
        /// </value>
        public bool? City { get; set; }

        /// <summary>
        /// Get or set the Country
        /// </summary>
        /// <value>
        /// patient Country
        /// </value>
        [Obsolete("Use MobilePhoneCountryCodeId instead")]
        public bool? Country { get; set; }
        /// <summary>
        /// Get or set the Mobile Phone Country Code Id
        /// </summary>
        /// <value>
        /// Mobile Phone Country Code Id
        /// </value>
        public bool? MobilePhoneCountryCodeId { get; set; }
        /// <summary>
        /// Get or set the CurrentMedications
        /// </summary>
        /// <value>
        /// CurrentMedications
        /// </value>
        public bool? CurrentMedications { get; set; }
        /// <summary>
        /// Get or set the Dob
        /// </summary>
        /// <value>
        /// Dob
        /// </value>
        public bool? Dob { get; set; }
        /// <summary>
        /// Get or set the patient email
        /// </summary>
        /// <value>
        /// patient email
        /// </value>

        public bool? Email { get; set; }
        /// <summary>
        /// Get or set the Ethnicity
        /// </summary>
        /// <value>
        /// Ethnicity
        /// </value>
        public bool? Ethnicity { get; set; }
        /// <summary>
        /// Get or set the EyeColor
        /// </summary>
        /// <value>
        /// EyeColor
        /// </value>
        public bool? EyeColor { get; set; }
        /// <summary>
        /// Get or set the Family Pediatrician
        /// </summary>
        /// <value>
        /// FamilyPediatrician
        /// </value>
        public bool? FamilyPediatrician { get; set; }
        /// <summary>
        /// Get or set the Family Pediatrician Contact
        /// </summary>
        /// <value>
        /// Family Pediatrician Contact
        /// </value>
        public bool? FamilyPediatricianContact { get; set; }
        /// <summary>
        /// Get or set the Gender
        /// </summary>
        /// <value>
        ///Gender
        /// </value>
        public bool? Gender { get; set; }
        /// <summary>
        /// Get or set the HairColor
        /// </summary>
        /// <value>
        ///HairColor
        /// </value>
        public bool? HairColor { get; set; }
        /// <summary>
        /// Get or set the Height
        /// </summary>
        /// <value>
        ///Height
        /// </value>

        public bool? Height { get; set; }
        /// <summary>
        /// Get or set the Height
        /// </summary>
        /// <value>
        ///Height
        /// </value>

        public bool? HeightUnit { get; set; }
        /// <summary>
        /// Get or set HomePhone
        /// </summary>
        /// <value>
        ///HomePhone
        /// </value>
        public bool? HomePhone { get; set; }
        /// <summary>
        /// Get or set HospitalId
        /// </summary>
        /// <value>
        ///HospitalId
        /// </value>
        public int HospitalId { get; set; }
        /// <summary>
        /// Get or set LastName
        /// </summary>
        /// <value>
        ///LastName
        /// </value>
        public bool? LastName { get; set; }
        /// <summary>
        /// Get or set Location
        /// </summary>
        /// <value>
        ///Location
        /// </value>
        public bool? Location { get; set; }
        /// <summary>
        /// Get or set Medical Conditions
        /// </summary>
        /// <value>
        ///MedicalConditions
        /// </value>
        public bool? MedicalConditions { get; set; }
        /// <summary>
        /// Get or set MedicationAllergies
        /// </summary>
        /// <value>
        ///MedicationAllergies
        /// </value>
        public bool? MedicationAllergies { get; set; }
        /// <summary>
        /// Get or set MobilePhone
        /// </summary>
        /// <value>
        ///MobilePhone
        /// </value>
        public bool? MobilePhone { get; set; }
        /// <summary>
        /// Get or set Organization
        /// </summary>
        /// <value>
        ///Organization
        /// </value>
        public bool? Organization { get; set; }
        /// <summary>
        /// Get or set PatientName
        /// </summary>
        /// <value>
        ///PatientName
        /// </value>
        public bool? PatientName { get; set; }
        /// <summary>
        /// Get or set Pharmacy Contact
        /// </summary>
        /// <value>
        ///Pharmacy Contact
        /// </value>
        public bool? PharmacyContact { get; set; }
        /// <summary>
        /// Get or set Physician Specialist
        /// </summary>
        /// <value>
        ///PhysicianSpecialist
        /// </value>
        public bool? PhysicianSpecialist { get; set; }
        /// <summary>
        /// Get or set PhysicianSpecialistContact
        /// </summary>
        /// <value>
        ///PhysicianSpecialistContact
        /// </value>
        public bool? PhysicianSpecialistContact { get; set; }
        /// <summary>
        /// Get or set PreferedPharmacy
        /// </summary>
        /// <value>
        ///PreferedPharmacy
        /// </value>
        public bool? PreferedPharmacy { get; set; }
        /// <summary>
        /// Get or set PrimaryPhysician
        /// </summary>
        /// <value>
        ///PrimaryPhysician
        /// </value>
        public bool? PrimaryPhysician { get; set; }
        /// <summary>
        /// Get or set PrimaryPhysicianContact
        /// </summary>
        /// <value>
        ///PrimaryPhysicianContact
        /// </value>
        public bool? PrimaryPhysicianContact { get; set; }
        /// <summary>
        /// Get or set PriorSurgeries
        /// </summary>
        /// <value>
        ///PriorSurgeries
        /// </value>

        public bool? PriorSurgeries { get; set; }
        /// <summary>
        /// Get or set SchoolContact
        /// </summary>
        /// <value>
        ///SchoolContact
        /// </value>
        public bool? SchoolContact { get; set; }
        /// <summary>
        /// Get or set SchoolName
        /// </summary>
        /// <value>
        ///SchoolName
        /// </value>
        public bool? SchoolName { get; set; }
        /// <summary>
        /// Get or set State
        /// </summary>
        /// <value>
        ///State
        /// </value>
        public bool? State { get; set; }
        /// <summary>
        /// Get or set StateId
        /// </summary>
        /// <value>
        ///StateId
        /// </value>

        public bool? StateId { get; set; }
        /// <summary>
        /// Get or set TimeZone
        /// </summary>
        /// <value>
        ///TimeZone
        /// </value>
        public bool? TimeZone { get; set; }
        /// <summary>
        /// Get or set Weight
        /// </summary>
        /// <value>
        ///Weight
        /// </value>
        public bool? Weight { get; set; }
        /// <summary>
        /// Get or set WeightUnit
        /// </summary>
        /// <value>
        ///WeightUnit
        /// </value>
        public bool? WeightUnit { get; set; }
        /// <summary>
        /// Get or set ZipCode
        /// </summary>
        /// <value>
        ///ZipCode
        /// </value>
        public bool? ZipCode { get; set; }
    }
}
