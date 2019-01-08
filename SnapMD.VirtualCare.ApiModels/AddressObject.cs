using System;
using System.Text;

namespace SnapMD.VirtualCare.ApiModels
{
    /// <summary>
    /// Represent the Address Object.
    /// </summary>
    public class AddressObject
    {
        /// <summary>
        /// Get or set the Address Line1
        /// </summary>
        /// <value>
        /// Address Line1
        /// </value>
        public string Line1 { get; set; } = string.Empty;

        /// <summary>
        /// Get or set the Address Line2
        /// </summary>
        /// <value>
        /// Address Line2
        /// </value>
        public string Line2 { get; set; } = string.Empty;

        /// <summary>
        /// Get or set the  City
        /// </summary>
        /// <value>
        /// City
        /// </value>
        public string City { get; set; } = string.Empty;

        /// <summary>
        /// Get or set the  State
        /// </summary>
        /// <value>
        /// State
        /// </value>
        public string State { get; set; } = string.Empty;

        /// <summary>
        /// Get or set the  State Code
        /// </summary>
        /// <value>
        /// State Code
        /// </value>
        public string StateCode { get; set; } = string.Empty;

        /// <summary>
        /// Get or set the  PostalCode
        /// </summary>
        /// <value>
        /// Postal Code
        /// </value>
        public string PostalCode { get; set; } = string.Empty;

        /// <summary>
        /// Get or set the  Country
        /// </summary>
        /// <value>
        /// Country
        /// </value>
        public string Country { get; set; } = string.Empty;

        /// <summary>
        /// Get or set the  Country Code
        /// </summary>
        /// <value>
        /// Country Code
        /// </value>
        public string CountryCode { get; set; } = string.Empty;

        /// <summary>
        /// Get or set the  Address Text
        /// </summary>
        /// <value>
        /// Address Text
        /// </value>
        public string AddressText => ToString();

        /// <summary>
        /// Return the status Is Empty or Not 
        /// </summary>
        /// <value>
        /// Bool value true or false
        /// </value>
        public bool IsEmpty()
        {
#pragma warning disable S1067 // Expressions should not be too complex
            return string.IsNullOrWhiteSpace(Line1)
                || string.IsNullOrWhiteSpace(City)
                || string.IsNullOrWhiteSpace(State)
                || string.IsNullOrWhiteSpace(StateCode)
                || string.IsNullOrWhiteSpace(PostalCode)
                || string.IsNullOrWhiteSpace(Country)
                || string.IsNullOrWhiteSpace(CountryCode);
#pragma warning restore S1067 // Expressions should not be too complex
        }

        /// <summary>
        /// Return the status Is Equals 
        /// </summary>
        /// <value>
        /// Bool value true or false
        /// </value>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (!ReferenceEquals(this, obj))
            {
                return obj.GetType() == this.GetType() && Equals((AddressObject)obj);
            }

            return true;
        }

        private bool Equals(AddressObject other)
        {
#pragma warning disable S1067 // Expressions should not be too complex
            return string.Equals(Line1, other.Line1, StringComparison.OrdinalIgnoreCase) 
                   && string.Equals(Line2, other.Line2, StringComparison.OrdinalIgnoreCase) 
                   && string.Equals(City, other.City, StringComparison.OrdinalIgnoreCase) 
                   && string.Equals(State, other.State, StringComparison.OrdinalIgnoreCase) 
                   && string.Equals(StateCode, other.StateCode, StringComparison.OrdinalIgnoreCase) 
                   && string.Equals(PostalCode, other.PostalCode, StringComparison.OrdinalIgnoreCase) 
                   && string.Equals(Country, other.Country, StringComparison.OrdinalIgnoreCase) 
                   && string.Equals(CountryCode, other.CountryCode, StringComparison.OrdinalIgnoreCase);
#pragma warning restore S1067 // Expressions should not be too complex
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            AppendIfNotEmpty(sb, Line1);
            AppendIfNotEmpty(sb, Line2);
            AppendIfNotEmpty(sb, City);
            AppendIfNotEmpty(sb, StateCode);
            AppendIfNotEmpty(sb, PostalCode, false);
            AppendIfNotEmpty(sb, CountryCode);

            return sb.ToString();
        }

        private static void AppendIfNotEmpty(StringBuilder sb, string prop, bool comma = true)
        {
            if (string.IsNullOrWhiteSpace(prop))
            {
                return;
            }

            if (sb.Length > 0)
            {
                sb.Append(comma ? ", " : " ");
            }

            sb.Append(prop);
        }
    }
}
