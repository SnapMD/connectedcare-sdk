namespace SnapMD.ConnectedCare.ApiModels
{
    /// <summary>
    ///     Represents public information for a clinician that is suitable for patient use.
    /// </summary>
    public class UserProfilesResult 
    {
        public string FirstName { get; set; }

        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }

        public string Gender { get; set; }

        public string LastName { get; set; }

        public int ProfileId { get; set; }

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

        public string TimeZone { get; set; }

        public int TimeZoneId { get; set; }

        public int UserId { get; set; }

    }
}
