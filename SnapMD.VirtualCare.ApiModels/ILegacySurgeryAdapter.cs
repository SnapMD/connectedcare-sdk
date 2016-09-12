namespace SnapMD.VirtualCare.ApiModels
{
    /// <summary>
    /// Legacy interface for the surgeries listed in the patient's medical history.
    /// </summary>
    public interface ILegacySurgeryAdapter
    {
        /// <summary>
        /// Gets or sets the prior surgery1.
        /// </summary>
        /// <value>
        /// The prior surgery1.
        /// </value>
        string PriorSurgery1 { get; set; }

        /// <summary>
        /// Gets or sets the prior surgery2.
        /// </summary>
        /// <value>
        /// The prior surgery2.
        /// </value>
        string PriorSurgery2 { get; set; }

        /// <summary>
        /// Gets or sets the prior surgery3.
        /// </summary>
        /// <value>
        /// The prior surgery3.
        /// </value>
        string PriorSurgery3 { get; set; }

        /// <summary>
        /// Gets or sets the surgery1 month.
        /// </summary>
        /// <value>
        /// The surgery1 month.
        /// </value>
        int? Surgery1Month { get; set; }

        /// <summary>
        /// Gets or sets the surgery2 month.
        /// </summary>
        /// <value>
        /// The surgery2 month.
        /// </value>
        int? Surgery2Month { get; set; }

        /// <summary>
        /// Gets or sets the surgery3 month.
        /// </summary>
        /// <value>
        /// The surgery3 month.
        /// </value>
        int? Surgery3Month { get; set; }

        /// <summary>
        /// Gets or sets the surgery1 year.
        /// </summary>
        /// <value>
        /// The surgery1 year.
        /// </value>
        int? Surgery1Year { get; set; }

        /// <summary>
        /// Gets or sets the surgery2 year.
        /// </summary>
        /// <value>
        /// The surgery2 year.
        /// </value>
        int? Surgery2Year { get; set; }

        /// <summary>
        /// Gets or sets the surgery3 year.
        /// </summary>
        /// <value>
        /// The surgery3 year.
        /// </value>
        int? Surgery3Year { get; set; }
    }
}