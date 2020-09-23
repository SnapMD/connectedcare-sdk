//    Copyright 2016 SnapMD, Inc.
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
//        http://www.apache.org/licenses/LICENSE-2.0
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.

using System;

namespace SnapMD.VirtualCare.ApiModels
{
    /// <summary>
    /// Encapsultae the Prescribing Location
    /// </summary>
    [Serializable]
    public class PrescribingLocationItem
    {
        /// <value>
        ///     The Id.
        /// </value>
        public string Id { get; set; }

        public string ClinicName { get; set; }

        public string Phone { get; set; }

        public string Fax { get; set; }

        public string AddressLine1 { get; set; } = string.Empty;

        /// <summary>
        /// Get or set the Address Line2
        /// </summary>
        /// <value>
        /// Address Line2
        /// </value>
        public string AddressLine2 { get; set; } = string.Empty;

        /// <summary>
        /// Get or set the  City
        /// </summary>
        /// <value>
        /// City
        /// </value>
        public string City { get; set; } = string.Empty;

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
        /// Get or set the  Country Code
        /// </summary>
        /// <value>
        /// Country Code
        /// </value>
        public string CountryCode { get; set; } = string.Empty;
    }
}
