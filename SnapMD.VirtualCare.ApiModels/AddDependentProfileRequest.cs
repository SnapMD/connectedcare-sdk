namespace SnapMD.VirtualCare.ApiModels
{
    public class AddDependentProfileRequest : AddPatientProfileRequest
    {
        /// <summary>
        /// Relationship for new dependent
        /// </summary>
        public DependentRelationship Relationship { get; set; }
    }
}