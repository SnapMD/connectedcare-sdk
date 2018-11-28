namespace SnapMD.VirtualCare.ApiModels
{
    /// <summary>
    /// The object used to encapsulate a Dependent Relationship.
    /// </summary>
    public class DependentRelationship
    {
        /// <summary>
        /// The Relation code Id.
        /// </summary>
        public int RelationCodeId { get; set; }
        /// <summary>
        /// The Dependent is authorized.
        /// </summary>
        public string IsAuthorized { get; set; }

    }

}