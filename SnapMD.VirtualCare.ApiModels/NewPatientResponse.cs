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
    ///    Encapsulate the new patient response.
    /// </summary>
    public class NewPatientResponse
    {
        /// <summary>
        ///     Gets or sets the Address.
        /// </summary>
        /// <value>
        ///     The Address.
        /// </value>
        public string Address { get; set; }

        /// <summary>
        ///     Gets or sets the Address.
        /// </summary>
        /// <value>
        ///     1.Line1.
        ///     2.Line2
        ///     3.City
        ///     4.State
        ///     5.StateCode
        ///     6.PostalCode
        ///     7.Country
        ///     8.CountryCode
        ///     8.AddressTest
        /// </value>
        public AddressObject AddressObject { get; set; }

        /// <summary>
        ///     Gets or sets the Date of Birth.
        /// </summary>
        /// <value>
        ///     The Date of Birth.
        /// </value>
        public DateTime? Dob { get; set; }

        /// <summary>
        ///     Gets or sets the Time zone.
        /// </summary>
        /// <value>
        ///     Time zone ID.
        /// </value>
        public int TimeZoneId { get; set; }

        /// <summary>
        ///     Gets or sets the Email.
        /// </summary>
        /// <value>
        ///     Patient Email.
        /// </value>
        public string Email { get; set; }

        /// <summary>
        ///     Gets or sets the patient Name.
        /// </summary>
        /// <value>
        ///     Patient Name.
        /// </value>
        public FirstLast Name { get; set; }


        /// <summary>
        ///     Gets or sets the patient Id.
        /// </summary>
        /// <value>
        ///     Patient Id.
        /// </value>
        public int PatientId { get; set; }

        /// <summary>
        ///     Gets or sets the provider Id.
        /// </summary>
        /// <value>
        ///     ProviderId.
        /// </value>
        public int ProviderId { get; set; }

        /// <summary>
        ///     Gets or sets the User Login Id.
        /// </summary>
        /// <value>
        ///     UserLoginId.
        /// </value>
        public int UserLoginId { get; set; }


        /// <summary>
        ///     Gets or sets the Gender.
        /// </summary>
        /// <value>
        ///     Gender.
        /// </value>
        public string Gender { get; set; }

        /// <summary>
        ///     Gets or sets the Mobile phone.
        /// </summary>
        /// <value>
        ///     MobilePhone.
        /// </value>
        public string MobilePhone { get; set; }
    }
}
