using System;

namespace SnapMD.VirtualCare.ApiModels
{
    public class PatientRecord
    {
        public string Height { get; set; }

        public string Weight { get; set; }

        public string HeightUnit { get; set; }

        public string WeightUnit { get; set; }

        public string Address { get; set; }

        public string HomePhone { get; set; }

        public string MobilePhone { get; set; }

        public DateTime? Dob { get; set; }

        public string Gender { get; set; }

        public string OrganizationName { get; set; }

        public string LocationName { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string ProfileImagePath { get; set; }
    }
}
