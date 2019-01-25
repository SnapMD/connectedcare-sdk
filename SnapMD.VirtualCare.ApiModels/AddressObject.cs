using System;
using System.Text;

namespace SnapMD.VirtualCare.ApiModels
{
    public class AddressObject
    {
        public string Line1 { get; set; } = string.Empty;
        public string Line2 { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string StateCode { get; set; } = string.Empty;
        public string PostalCode { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string CountryCode { get; set; } = string.Empty;
        public string AddressText => ToString();

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

        /// <summary>
        /// Override the string function.
        /// </summary>
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
