namespace SnapMD.VirtualCare.ApiModels
{
    /// <summary>
    ///     The name of the individual.  FHIR HL-7-compatible.
    /// </summary>
    public class PersonName
    {
        /// <summary>
        ///     Given names (not always 'first').  Includes middle names.  Comma-separated values accepted.
        /// </summary>
        public virtual string Given { get; set; }

        /// <summary>
        ///     Parts that come before the name.  Comma-separated values accepted.
        /// </summary>
        public virtual string Prefix { get; set; }

        /// <summary>
        ///     Parts that come after the name.  Comma-separated values accepted.
        /// </summary>
        public virtual string Suffix { get; set; }

        /// <summary>
        ///     Gets or sets the Full Name.  This should be input instead of calculated.  For example, some cultures put Family
        ///     Name and Given Name in a different order.
        ///     Conversion utilities may coalesce a name based on fields already in record, but it might not the desired results.
        /// </summary>
        /// <value>
        ///     The text.
        /// </value>
        public virtual string Text { get; set; }

        /// <summary>
        ///     Family name (often called 'Surname', or 'last name' in many cultures).  Hyphenated or comma-separated values
        ///     accepted.
        /// </summary>
        public virtual string Family { get; set; }
    }
}
