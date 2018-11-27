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
    /// Represents New Patient Response.
    /// </summary>
    public class NewPatientResponse
    {
        /// <summary>
        ///     Get or Set the Address.
        /// </summary>
        /// <value>
        ///    Address
        /// </value>
        public string Address { get; set; }
        /// <summary>
        ///     Get or Set AddressObject.
        /// </summary>
        /// <value>
        ///    Line 1
        ///    Line 2
        ///    City 
        ///    State
        ///    StateCode
        ///    PostalCode
        ///    Country
        ///    CountryCode
        ///    AddressText
        /// </value>
        public AddressObject AddressObject { get; set; }
        /// <summary>
        ///     Get or Set the Date of Birth.
        /// </summary>
        /// <value>
        ///    Date of Birth
        /// </value>
        public DateTime? Dob { get; set; }
        /// <summary>
        ///     Get or Set the Time Zone Id.
        /// </summary>
        /// <value>
        ///   TimeZoneId
        /// </value>

        public int TimeZoneId { get; set; }
        /// <summary>
        ///     Get or Set the Email.
        /// </summary>
        /// <value>
        ///   Email
        /// </value>

        public string Email { get; set; }
        /// <summary>
        ///     Get or Set the Name.
        /// </summary>
        /// <value>
        ///   Name
        /// </value>

        public FirstLast Name { get; set; }
        /// <summary>
        ///     Get or Set the Patient Id.
        /// </summary>
        /// <value>
        ///   PatientId
        /// </value>

        public int PatientId { get; set; }
        /// <summary>
        ///     Get or Set the Provider Id.
        /// </summary>
        /// <value>
        ///   ProviderId
        /// </value>

        public int ProviderId { get; set; }
        /// <summary>
        ///     Get or Set the UserLoginId.
        /// </summary>
        /// <value>
        ///   UserLoginId
        /// </value>

        public int UserLoginId { get; set; }
        /// <summary>
        ///     Get or Set the Gender.
        /// </summary>
        /// <value>
        ///   Male or Female
        /// </value>

        public string Gender { get; set; }
        /// <summary>
        ///     Get or Set the MobilePhone.
        /// </summary>
        /// <value>
        ///  MobilePhone
        /// </value>
        public string MobilePhone { get; set; }
    }
}
