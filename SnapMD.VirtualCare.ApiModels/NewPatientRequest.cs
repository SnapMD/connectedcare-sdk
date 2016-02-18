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
    public class NewPatientRequest
    {
        public string Address { get; set; }

        public DateTime? Dob { get; set; }

        public string Email { get; set; }

        public FirstLast Name { get; set; }

        public string Password { get; set; }

        public int ProviderId { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Country { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string ZipCode { get; set; }

        //Token is used for co-user only
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Token { get; set; }

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
                    throw exceptionToThrow("Name is required");
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

            return true;
        }
    }
}
