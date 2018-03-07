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
using System.Collections.Generic;

namespace SnapMD.VirtualCare.ApiModels
{
    /// <summary>
    /// PatientOnBoardShortDetail
    /// </summary>
    public class PatientOnBoardShortDetail
    {
        /// <summary>
        /// Gets or sets the patient identifier.
        /// </summary>
        /// <value>
        /// The patient identifier.
        /// </value>
        public int PatientId { get; set; }

        /// <summary>
        /// FirstName
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// LastName
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Dob
        /// </summary>
        public DateTime? Dob { get; set; }

        /// <summary>
        /// Full address in free-form.
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Structurized address
        /// </summary>
        public AddressObject AddressObject { get; set; }

        /// <summary>
        /// GET 'api/countrycode'
        /// </summary>
        public int? CountryId { get; set; }

        /// <summary>
        /// GET 'api/timezone'
        /// </summary>
        public int? TimeZoneId { get; set; }

        /// <summary>
        /// Mobile number with country code
        /// </summary>
        public string MobileNumberWithCountryCode { get; set; }

        /// <summary>
        /// M/F
        /// </summary>
        public string Gender { get; set; }

        /// <summary>
        /// PatientOnBoardStatus
        /// </summary>
        public PatientOnBoardStatus? Status { get; set; }

        /// <summary>
        /// Validate model
        /// </summary>
        /// <param name="exceptionToThrow">exceptionToThrow</param>
        /// <param name="allowNullEmail">allowNullEmail</param>
        /// <returns></returns>
        public bool ValidateModel(Func<string, Exception> exceptionToThrow = null, bool allowNullEmail = false)
        {
            if (exceptionToThrow == null)
            {
                exceptionToThrow = message => new ArgumentException(message);
            }

            if (string.IsNullOrEmpty(FirstName))
            {
                // error: first name required.
                throw exceptionToThrow("First name required.");
            }

            if (!allowNullEmail && string.IsNullOrWhiteSpace(Email))
            {
                // error: email required.
                throw exceptionToThrow("Email address required.");
            }

            var genders = new List<string> { "M", "F" };
            if (string.IsNullOrEmpty(Gender) || !genders.Contains(Gender))
            {
                // error: gender unknown.
                throw exceptionToThrow(string.Format("Unknown gender. Expected gender any [{0}]", string.Join(", ", genders.ToArray())));
            }

            if (Dob == null)
            {
                // error: date of birth required.
                throw exceptionToThrow("Date of birth required.");
            }
            if (string.IsNullOrEmpty(Address) && AddressObject.SafeIsEmpty())
            {
                // error: address required.
                throw exceptionToThrow("Address required.");
            }

            if (string.IsNullOrEmpty(MobileNumberWithCountryCode))
            {
                // error: mobile number required.
                throw exceptionToThrow("Mobile number required.");
            }

            return true;
        }
    }

    /// <summary>
    /// PatientOnBoardShortDetailRequest
    /// </summary>
    public class PatientOnBoardShortDetailRequest : PatientOnBoardShortDetail
    {
        /// <summary>
        /// Prevent sending invitation email
        /// </summary>
        public bool? PreventSendingInvitation { get; set; }

        /// <summary>
        /// Create [User] record even if <see cref="PatientOnBoardShortDetail.Email"/> is null.
        /// </summary>
        public bool CreateUserWithoutEmail { get; set; }
    }
}