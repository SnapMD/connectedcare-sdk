namespace SnapMD.ConnectedCare.ApiModels
{

    public struct GetPatientsResponse
    {
        public string PatientName { get; set; }
        public string LastName { get; set; }
        public string MobilePhone { get; set; }
        public string ProfileImagePath { get; set; }
        public string HomePhone { get; set; }
        public string PrimaryPhysician { get; set; }
        public string PrimaryPhysicianContact { get; set; }
        public string PhysicianSpecialist { get; set; }
        public string PhysicianSpecialistContact { get; set; }
        public string Organization { get; set; }
        public string Location { get; set; }
        public int? OrganizationId { get; set; }
        public int? LocationId { get; set; }

    }
}