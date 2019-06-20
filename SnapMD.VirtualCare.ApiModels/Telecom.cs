using System;

namespace SnapMD.VirtualCare.ApiModels
{
    /// <summary>
    /// Encapsulate Telecom
    /// </summary>
    public class Telecom
    {
        /// <summary>
        /// Get or set the Telecom Id
        /// </summary>
        /// <value> GUID </value>
        public Guid Id { get; set; }
        /// <summary>
        /// Get or set the Zip Code
        /// </summary>
        public string Zip { get; set; }
        /// <summary>
        /// Get or set the telecom value
        /// </summary>
        public string Value { get; set; }
        /// <summary>
        /// Get or set the telecom System
        /// </summary>
        /// <value> value type int and null value allow </value>
        public int? System { get; set; }
        /// <summary>
        /// Get or set the telecom Use
        /// </summary>
        /// <value> value type int and null value allow </value>
        public int? Use { get; set; }
        /// <summary>
        /// Get or set the Rank 
        /// </summary>
        /// <value> value type int and null value allow </value>
        public int? Rank { get; set; }
    }
}
