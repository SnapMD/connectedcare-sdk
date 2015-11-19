//    Copyright 2015 SnapMD, Inc.
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

namespace SnapMD.ConnectedCare.ApiModels
{
    public class PatientOnBoardShortDetail
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public DateTime? Dob { get; set; }

        /// <summary>
        /// Full address in free-form.
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// GET 'api/countrycode'
        /// </summary>
        public int? CountryId { get; set; }

        /// <summary>
        /// GET 'api/timezone'
        /// </summary>
        public int? TimeZoneId { get; set; }
        public string MobileNumberWithCountryCode { get; set; }

        /// <summary>
        /// M/F
        /// </summary>
        public string Gender { get; set; }
    }
}
