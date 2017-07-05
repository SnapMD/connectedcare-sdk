using System;
using System.Collections.Generic;

namespace SnapMD.VirtualCare.ApiModels
{
    public class PatientUpdateRequest
    {
        public int PatientId { get; set; }
        public string PatientName { get; set; }
        public string LastName { get; set; }
        public DateTime? Dob { get; set; }
        public int? BloodType { get; set; }
        public int? EyeColor { get; set; }
        public string Gender { get; set; }
        public int? Ethnicity { get; set; }
        public int? HairColor { get; set; }
        public string HomePhone { get; set; }
        public string MobilePhone { get; set; }
        public string SchoolName { get; set; }
        public string SchoolContact { get; set; }
        public string PrimaryPhysician { get; set; }
        public string PrimaryPhysicianContact { get; set; }
        public string PhysicianSpecialist { get; set; }
        public string PhysicianSpecialistContact { get; set; }
        public string PreferedPharmacy { get; set; }
        public string PharmacyContact { get; set; }
        public string Address { get; set; }
        public string ProfileImagePath { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public int? HeightUnit { get; set; }
        public int? WeightUnit { get; set; }
        public string Organization { get; set; }
        public string Location { get; set; }
        public int? OrganizationId { get; set; }
        public int? LocationId { get; set; }
        public IList<IdentifierValue> Identifiers { get; set; }

        [Obsolete("Use MobilePhoneCountryCodeId instead")]
        public string CountryCode { get; set; }

        public int? MobilePhoneCountryCodeId { get; set; }
    }
}