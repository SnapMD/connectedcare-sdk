namespace SnapMD.VirtualCare.ApiModels
{
    /// <summary>
    /// SortOrder
    /// </summary>
    public enum SortOrder
    {
        /// <summary>
        /// Default None
        /// </summary>
        None,

        /// <summary>
        /// Ascending
        /// </summary>
        Ascending,

        /// <summary>
        /// Desceniding
        /// </summary>
        Descending
    }

    /// <summary>
    /// Sorting order of a given resultset
    /// </summary>
    public class DataSortOrder
    {
        /// <summary>
        /// ColumnName
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Sort Direction
        /// </summary>
        public SortOrder SortOrder { get; set; }
    }
}
