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

using Newtonsoft.Json;
using System;

namespace SnapMD.VirtualCare.ApiModels
{
    /// <summary>
    /// Model for creating new patient
    /// </summary>
    public class NewPatientRequest
    {
        /// <summary>
        /// Patient Address
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Patient Dob
        /// </summary>
        public DateTime? Dob { get; set; }
        
        /// <summary>
        /// TimeZoneId
        /// </summary>
        public int TimeZoneId { get; set; }

        /// <summary>
        /// Valid email address
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// First and Last name
        /// </summary>
        public FirstLast Name { get; set; }

        /// <summary>
        /// Password
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// ProviderId
        /// </summary>
        public int ProviderId { get; set; }

        /// <summary>
        /// Country
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Country { get; set; }

        /// <summary>
        /// Zipcode
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string ZipCode { get; set; }

        /// <summary>
        /// Token. This is being used for co-user only
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Token { get; set; }

        /// <summary>
        /// Gender M|F
        /// </summary>
        public string Gender { get; set; }

        /// <summary>
        /// MobilePhone with CountryCode (+142568848 or +446039584)
        /// </summary>
        public string MobilePhone { get; set; }

        /// <summary>
        /// Validates NewPatientRequest
        /// </summary>
        /// <param name="exceptionToThrow">exceptionToThrow</param>
        /// <returns></returns>
        public bool ValidateModel(Func<string, Exception> exceptionToThrow = null)
        {
            if (exceptionToThrow == null)
            {
                exceptionToThrow = message => new ArgumentException(message);
            }

            if (Token == null)
            {
                if (Name == null)
                {
                    throw exceptionToThrow("Name is required.");
                }

                if (string.IsNullOrEmpty(Name.First))
                {
                    // error: first name required.
                    throw exceptionToThrow("First name required.");
                }

                if (string.IsNullOrEmpty(Email))
                {
                    // error: email required.
                    throw exceptionToThrow("Email address required.");
                }

                if (string.IsNullOrEmpty(Address))
                {
                    // error: address required.
                    throw exceptionToThrow("Address required.");
                }
            }
            if (Dob == null)
            {
                // error: date of birth required.
                throw exceptionToThrow("Date of birth required.");
            }


            if (ProviderId <= 0)
            {
                // error: mobile number required.
                throw exceptionToThrow("ProviderId required.");
            }

            if (!string.IsNullOrEmpty(MobilePhone) && !MobilePhone.StartsWith("+"))
            {
                throw exceptionToThrow("Country code is required while entering MobilePhone");
            }

            if (!string.IsNullOrEmpty(Gender) && !(Gender.ToUpper() == "M" || Gender.ToUpper() == "F"))
            {
                throw exceptionToThrow($"Invalid entry for gender {Gender}");
            }
            return true;
        }
    }
}
