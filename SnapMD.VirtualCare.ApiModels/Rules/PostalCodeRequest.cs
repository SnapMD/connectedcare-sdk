using System;

namespace SnapMD.VirtualCare.ApiModels.Rules
{
    /// <summary>
    /// Request Model for PostalCode requests
    /// </summary>
    /// <seealso cref="SnapMD.VirtualCare.ApiModels.Rules.SubjectAddress" />
    public class PostalCodeRequest : SubjectAddress
    {
        /// <summary>
        /// Gets or sets the postal code identifier.
        /// </summary>
        /// <value>
        /// The postal code identifier.
        /// </value>
        public Guid? PostalCodeId { get; set; }

        /// <summary>
        /// Partial text of state, city or postal code for search.
        /// </summary>
        /// <value>
        /// The search text.
        /// </value>
        public string SearchText { get; set; }

        /// <summary>
        /// The maximum rows should be returned from the search results.
        /// </summary>
        /// <value>
        /// The maximum rows.
        /// </value>
        public int? MaxRows { get; set; }
    }
}
