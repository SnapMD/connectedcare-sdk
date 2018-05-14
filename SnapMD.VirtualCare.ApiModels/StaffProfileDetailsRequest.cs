using System;
using System.Collections.Generic;

namespace SnapMD.VirtualCare.ApiModels
{
    /// <summary>
    /// Staff profile information.
    /// </summary>
    public class StaffProfileDetailsRequest
    {
        /// <summary>
        /// Doctor Day Of Birth.
        /// Example: Nov 11, 1978
        /// </summary>
        public DateTime? Dob { get; set; }

        /// <summary>
        /// Doctor practicing since this year.
        /// Example: 2005
        /// </summary>
        public int PracticingSinceYear { get; set; }

        /// <summary>
        /// Doctor gender.
        /// Possible values: 
        /// 1. 'M' - male
        /// 2. 'F' - female
        /// </summary>
        public string Gender { get; set; }

        /// <summary>
        /// Doctor Internship
        /// </summary>
        public string Internship { get; set; }

        /// <summary>
        /// Doctor department.
        /// If there is no department with such name, new department will be created.
        /// </summary>
        public string Department { get; set; }

        /// <summary>
        /// Doctor medical speciality.
        /// If there is no such medical speciality, new medical speciality will be created.
        /// </summary>
        public string MedicalSpeciality { get; set; }

        /// <summary>
        /// Doctor medical sub speciality.
        /// If there is no such medical sub speciality, new medical sub speciality will be created.
        /// </summary>
        public string MedicalSubSpeciality { get; set; }

        /// <summary>
        /// Doctor medical license.
        /// </summary>
        public string MedicalLicense { get; set; }

        /// <summary>
        /// Doctor States Licensed.
        /// </summary>
        public string StatesLicensed { get; set; }

        /// <summary>
        /// Doctor School Of Medecine.
        /// </summary>
        public string MedicineSchool { get; set; }

        /// <summary>
        /// Doctor Pre-Medical Education.
        /// </summary>
        public string PreMedicalEducation { get; set; }

        /// <summary>
        /// Doctor Year Of State Registration.
        /// This field usually used for hospitals with en-GB client language as default.
        /// </summary>
        public string YearOfStateRegistration { get; set; }

        /// <summary>
        /// Doctor residency (Home address).
        /// </summary>
        public string HomeAddress { get; set; }

        /// <summary>
        /// Doctor Current Business Address.
        /// </summary>
        public string BusinessAddress { get; set; }

        /// <summary>
        /// Doctor Current Business Address (Use this over BusinessAddress).
        /// </summary>
        public AddressObject BusinessAddressObject { get; set; }

        /// <summary>
        /// List of organizations/locations doctor/presenter may service.
        /// </summary>
        public IList<StaffServiceOrganizationModel>  ServiceOrganizations { get; set; }
    }

    /// <summary>
    ///  Organization doctor/presenter may service
    /// </summary>
    public class StaffServiceOrganizationModel
    {
        /// <summary>
        /// Organization id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Organization name. Presents in responses, ignored in requests.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// List of service locations inside this organization.
        /// Null or empty list is a wildcard meaning "all locations".
        /// </summary>
        public IList<StaffServiceLocationModel> Locations { get; set; }
    }

    /// <summary>
    ///  Location doctor/presenter may service
    /// </summary>
    public class StaffServiceLocationModel
    {
        /// <summary>
        /// Location id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Location name. Presents in responses, ignored in requests.
        /// </summary>
        public string Name { get; set; }
    }
}
