namespace SnapMD.ConnectedCare.ApiModels
{
    public class GuardianRecord
    {
        public int PatientId { get; set; }

        public int UserId { get; set; }

        public string Address { get; set; }

        public string HomePhone { get; set; }

        public string MobilePhone { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
