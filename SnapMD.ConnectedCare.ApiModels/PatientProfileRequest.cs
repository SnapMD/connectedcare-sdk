using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapMD.ConnectedCare.ApiModels
{
    public class PatientProfileRequest
    {
        public int PatientId { get; set; }
        public string PatientName { get; set; }
        public string LastName { get; set; }
        public DateTime? Dob { get; set; }
        public int? BloodType { get; set; }
        public int? EyeColor { get; set; }
        public string Gender { get; set; }
        public int? Enthicity { get; set; }
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

        public string ValidateInputs()
        {
            var Msg = string.Empty;
            var profile = this;

            if (profile.PatientName.Length < 1)
                Msg += "Please enter first name <br/>";
            if (profile.LastName.Length < 1)
                Msg += "Please enter last name <br/>";
            try
            {
                Convert.ToDateTime(profile.Dob);
                if (profile.Dob > DateTime.UtcNow.AddDays(1))
                    Msg += "Date of Birth can't be in the future <br/>";
            }
            catch
            {
                Msg += "Please enter a valid Data of birth format(MMM dd, yyyy) <br/>";
            }
            if (profile.Gender.Length < 1)
                Msg += "Please select gender <br/>";
            //removing ethnicity, we should check the blood, eycolor... from the hospital settings

            if (profile.Height.Trim().Length < 1 || profile.Height.Trim() == "|" || profile.Height.Trim() == "0|0"
                || profile.Height.Trim() == "0|" || profile.Height.Trim() == "|0")
                Msg += "Please enter height <br/>";

            if (profile.Weight.Trim().Length < 1)
                Msg += "Please enter weight <br/>";

            return Msg;
        }
    }
}
