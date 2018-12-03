using System;
using System.Collections.Generic;

namespace SnapMD.VirtualCare.ApiModels
{
    /// <summary>
    /// Represents Patient Update Request.
    /// </summary>
    public class PatientUpdateRequest
    {
        /// <summary>
        ///     Get or Set the Patient Id.
        /// </summary>
        /// <value>
        ///    PatientId
        /// </value> 
        public int PatientId { get; set; }
        /// <summary>
        ///     Get or Set the Patient Name.
        /// </summary>
        /// <value>
        ///    PatientName
        /// </value> 
        public string PatientName { get; set; }
        /// <summary>
        ///     Get or Set the Last Name.
        /// </summary>
        /// <value>
        ///    LastName
        /// </value>
        public string LastName { get; set; }
        /// <summary>
        ///     Get or Set the Dob.
        /// </summary>
        /// <value>
        ///    Dob
        /// </value> 
        public DateTime? Dob { get; set; }
        /// <summary>
        ///     Get or Set Blood Type.
        /// </summary>
        /// <value>
        ///    BloodType
        /// </value>
        public int? BloodType { get; set; }
        /// <summary>
        ///     Get or Set Eye Color.
        /// </summary>
        /// <value>
        ///    EyeColor
        /// </value>
        public int? EyeColor { get; set; }
        /// <summary>
        ///     Get or Set Gender.
        /// </summary>
        /// <value>
        ///    Gender
        /// </value>
        public string Gender { get; set; }
        /// <summary>
        ///     Get or Set Ethnicity.
        /// </summary>
        /// <value>
        ///    Ethnicity
        /// </value>
        public int? Ethnicity { get; set; }
        /// <summary>
        ///     Get or Set HairColor.
        /// </summary>
        /// <value>
        ///    HairColor
        /// </value>
        public int? HairColor { get; set; }
        /// <summary>
        ///     Get or Set HomePhone.
        /// </summary>
        /// <value>
        ///    HomePhone
        /// </value>
        public string HomePhone { get; set; }
        /// <summary>
        ///     Get or Set MobilePhone.
        /// </summary>
        /// <value>
        ///    MobilePhone
        /// </value>
        public string MobilePhone { get; set; }
        /// <summary>
        ///     Get or Set School Name.
        /// </summary>
        /// <value>
        ///    SchoolName
        /// </value>
        public string SchoolName { get; set; }
        /// <summary>
        ///     Get or Set School Contact.
        /// </summary>
        /// <value>
        ///    SchoolContact
        /// </value>
        public string SchoolContact { get; set; }
        /// <summary>
        ///     Get or Set  Physician.
        /// </summary>
        /// <value>
        ///    PrimaryPhysician
        /// </value>
        public string PrimaryPhysician { get; set; }
        /// <summary>
        ///     Get or Set  Physician Contact.
        /// </summary>
        /// <value>
        ///    PrimaryPhysicianContact
        /// </value>
        public string PrimaryPhysicianContact { get; set; }
        /// <summary>
        ///     Get or Set  Physician Specialist.
        /// </summary>
        /// <value>
        ///    PhysicianSpecialist
        /// </value>
        public string PhysicianSpecialist { get; set; }
        /// <summary>
        ///     Get or Set  Physician Specialist.
        /// </summary>
        /// <value>
        ///    PhysicianSpecialist
        /// </value>
        public string PhysicianSpecialistContact { get; set; }
        /// <summary>
        ///     Get or Set Prefered Pharmacy.
        /// </summary>
        /// <value>
        ///    PreferedPharmacy
        /// </value>
        public string PreferedPharmacy { get; set; }
        /// <summary>
        ///     Get or Set Pharmacy Contact.
        /// </summary>
        /// <value>
        ///    PharmacyContact
        /// </value>
        public string PharmacyContact { get; set; }
        /// <summary>
        ///     Get or Set Address.
        /// </summary>
        /// <value>
        ///    Address
        /// </value>
        public string Address { get; set; }
        /// <summary>
        ///     Get or Set Address Object.
        /// </summary>
        /// <value>
        ///    Line1
        ///    Line2
        ///    City
        ///    State
        ///    StateCode
        ///    PostalCode
        ///    Country
        ///    CountryCode
        ///    AddressText
        /// </value>
        public AddressObject AddressObject { get; set; }
        /// <summary>
        ///     Get or Set Profile Image Path.
        /// </summary>
        /// <value>
        ///    ProfileImagePath
        /// </value>
        public string ProfileImagePath { get; set; }
        /// <summary>
        ///     Get or Set Height.
        /// </summary>
        /// <value>
        ///    Height
        /// </value>
        public string Height { get; set; }
        /// <summary>
        ///     Get or Set Weight.
        /// </summary>
        /// <value>
        ///    Weight
        /// </value>
        public string Weight { get; set; }
        /// <summary>
        ///     Get or Set HeightUnit.
        /// </summary>
        /// <value>
        ///    HeightUnit
        /// </value>
        public int? HeightUnit { get; set; }
        /// <summary>
        ///     Get or Set WeightUnit.
        /// </summary>
        /// <value>
        ///    WeightUnit
        /// </value>
        public int? WeightUnit { get; set; }
        /// <summary>
        ///     Get or Set Organization.
        /// </summary>
        /// <value>
        ///    Organization
        /// </value>
        public string Organization { get; set; }
        /// <summary>
        ///     Get or Set Location.
        /// </summary>
        /// <value>
        ///    Location
        /// </value>
        public string Location { get; set; }
        /// <summary>
        ///     Get or Set OrganizationId.
        /// </summary>
        /// <value>
        ///    OrganizationId
        /// </value>
        public int? OrganizationId { get; set; }
        /// <summary>
        ///     Get or Set LocationId.
        /// </summary>
        /// <value>
        ///    LocationId
        /// </value>
        public int? LocationId { get; set; }
        /// <summary>
        ///     Get or Set Identifiers.
        /// </summary>
        /// <value>
        ///    Identifiers
        /// </value>
        public IList<IdentifierValue> Identifiers { get; set; }

        /// <summary>
        ///     Get or Set CountryCode.
        /// </summary>
        /// <value>
        ///    CountryCode
        /// </value>
        [Obsolete("Use MobilePhoneCountryCodeId instead")]
        public string CountryCode { get; set; }

        /// <summary>
        ///     Get or Set Mobile Phone Country CodeId.
        /// </summary>
        /// <value>
        ///    MobilePhoneCountryCodeId
        /// </value>
        public int? MobilePhoneCountryCodeId { get; set; }
    }
}