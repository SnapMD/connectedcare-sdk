using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SnapMD.VirtualCare.ApiModels;
using SnapMD.VirtualCare.ApiModels.Enums;
using System;

namespace SnapMD.VirtualCare.ApiModels
{
    /// <summary>
    /// Value of HL7 FHIR's identifier for Web API methods
    /// </summary>
    public class IdentifierValue
    {
        /// <summary>
        /// Alphanumeric identifier usage code
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public IdentifierUsageCode? IdentifierUsageCode { get; set; }

        /// <summary>
        /// Readable name of identifier usage
        /// </summary>
        public string IdentifierUsageTitle { get; set; }
        /// <summary>
        /// Alphanumeric identifier type code
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public IdentifierTypeCode IdentifierTypeCode { get; set; }

        /// <summary>
        /// Readable name of identifier type
        /// </summary>
        public string IdentifierTypeTitle { get; set; }

        /// <summary>
        /// FHIR's system
        /// </summary>
        public string Namespace { get; set; }

        /// <summary>
        /// Value of the identifier
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Date/time from which identifier value is valid
        /// </summary>
        public DateTime EffectiveDate { get; set; }

        /// <summary>
        /// Date/time until which identifier value is valid. If null, identifier will never expire
        /// </summary>
        public DateTime? ExpiredDate { get; set; }

        /// <summary>
        /// Organization assigned the iddentifier
        /// </summary>
        public string AssignerOrg { get; set; }

        /// <summary>
        /// Current status of the identifier value in the system
        /// </summary>
        public GlobalStatusCode StatusCode { get; set; }

        /// <summary>
        /// Is the identifier read only for the requested user
        /// </summary>
        public bool ReadOnly { get; set; }

        /// <summary>
        /// Modified by patient or provider or null means 'unknown'
        /// </summary>
        public bool? ModifiedByPatient { get; set; }
    }
}