using System;

namespace SnapMD.VirtualCare.ApiModels
{
    /// <summary>
    ///     Useful for smaller payloads when the name of the collection properly identifies the system (e.g. email, phone).
    /// </summary>
    public class SmallTelecom
    {
        /// <summary>
        ///     Gets or sets the identifier.
        /// </summary>
        /// <value>
        ///     The identifier.
        /// </value>
        public Guid Id { get; set; }

        /// <summary>
        ///     Gets or sets the use.  Acceptable values: "home", "work", "temp", "old", "other"
        /// </summary>
        /// <value>
        ///     The use.
        /// </value>
        public string Use { get; set; }

        /// <summary>
        ///     Gets or sets the value.
        /// </summary>
        /// <value>
        ///     The value.
        /// </value>
        public string Value { get; set; }
    }
}
