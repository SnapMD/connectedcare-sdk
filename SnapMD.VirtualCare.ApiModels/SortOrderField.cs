namespace SnapMD.VirtualCare.ApiModels
{
    /// <summary>
    /// SortOrderDirection
    /// </summary>
    public enum SortOrderDirection
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
    public class SortOrderField
    {
        /// <summary>
        /// Sorting ColumnName
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Sort Direction
        /// </summary>
        public SortOrderDirection SortOrderDirection { get; set; }
    }
}
