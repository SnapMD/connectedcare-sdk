using System;
using System.Text;

namespace SnapMD.VirtualCare.ApiModels
{
    /// <summary>
    ///     Represents public information for Address Location Object.
    /// </summary>
    public class AddressLocationObject
    {
        /// <summary>
        /// Get or set Line1
        /// </summary>
        /// <value>
        /// Line1
        /// </value>
        public string Line1 { get; set; }

        /// <summary>
        /// Get or set Line2
        /// </summary>
        /// <value>
        /// Line2
        /// </value>
        public string Line2 { get; set; }

        /// <summary>
        /// Get or set City
        /// </summary>
        /// <value>
        /// City
        /// </value>
        public string City { get; set; }
       
        /// <summary>
        /// Get or set State
        /// </summary>
        /// <value>
        /// State
        /// </value>
        public string State { get; set; }

        /// <summary>
        /// Get or set StateCode
        /// </summary>
        /// <value>
        /// StateCode
        /// </value>
        public string StateCode { get; set; }

        /// <summary>
        /// Get or set Postal Code
        /// </summary>
        /// <value>
        /// PostalCode
        /// </value>
        public string PostalCode { get; set; }
        
        /// <summary>
        /// Get or set Country
        /// </summary>
        /// <value>
        /// Country
        /// </value>
        public string Country { get; set; }

        /// <summary>
        /// Get or set Country Code
        /// </summary>
        /// <value>
        /// CountryCode
        /// </value>
        public string CountryCode { get; set; }

        /// <summary>
        /// Get or set Address Text
        /// </summary>
        /// <value>
        /// Address Text
        /// </value>
        public string AddressText { get; set; }
    }
}
