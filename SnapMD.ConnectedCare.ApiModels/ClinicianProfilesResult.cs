namespace SnapMD.ConnectedCare.ApiModels
{
    /// <summary>
    ///     Represents public information for a clinician that is suitable for patient use.
    /// </summary>
    public class ClinicianProfilesResult
    {
        public string BusinessAddress { get; set; }

        public string FirstName { get; set; }

        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }

        public string Gender { get; set; }

        public int HospitalId { get; set; }

        public string LastName { get; set; }

        public string MedicalLicense { get; set; }

        public string MedicalSpeciality { get; set; }

        public string MedicalSchool { get; set; }

        /// <summary>
        ///     Get Doctor profile image or default one.
        /// </summary>
        public string ProfileImage
        {
            get
            {
                if (!string.IsNullOrEmpty(ProfileImagePath))
                {
                    return ProfileImagePath;
                }

                return Gender == "F" ? "/images/Doctor-Female.gif" : "/images/Doctor-Male.gif";
            }
        }

        public string ProfileImagePath { get; set; }

        public string StatesLicenced { get; set; }

        public string SubSpeciality { get; set; }
    }
}
