namespace SnapMD.ConnectedCare.ApiModels
{
    /// <summary>
    /// Represents patient details for administrator patient lists.
    /// </summary>
    public class PatientAccountInfo
    {
        public int PatientId { get; set; }
        public int? UserId { get; set; }
        public string ProfileImagePath { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }

        public bool IsAuthorized { get; set; }
        public bool IsActive { get; set; }
    }
}
