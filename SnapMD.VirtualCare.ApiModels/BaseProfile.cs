#region Copyright
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
#endregion

using System;
using System.Collections.Generic;

namespace SnapMD.VirtualCare.ApiModels
{
    /// <summary>
    /// Provide base profile 
    /// </summary>
    public class BaseProfile
    {
        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>
        /// The fname.
        /// </value>
        public string Fname { get; set; }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>
        /// The lname.
        /// </value>
        public string Lname { get; set; }

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>
        /// The email.
        /// </value>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the phone number.
        /// </summary>
        /// <value>
        /// The ph number.
        /// </value>
        public string PhNumber { get; set; }

        /// <summary>
        /// Gets or sets the cell number.
        /// </summary>
        /// <value>
        /// The cell number.
        /// </value>
        public string CellNumber { get; set; }

        /// <summary>
        /// Gets or sets the text alert.
        /// </summary>
        /// <value>
        /// The text alert message.
        /// </value>
        public string TextAlerts { get; set; }
        /// <summary>
        /// Gets or sets the Image path.
        /// </summary>
        /// <value>
        /// The images path.
        /// </value>
        public string ImgPath { get; set; }

        /// <summary>
        /// Gets or sets date of birth.
        /// </summary>
        /// <value>
        /// The birth date .
        /// </value>
        public string DOB { get; set; }
        /// <summary>
        /// Gets or sets how many years prace.
        /// </summary>
        /// <value>
        /// The Practicing Year .
        /// </value>
        public int? YearPracticing { get; set; }

        /// <summary>
        /// Gets or sets the department.
        /// </summary>
        /// <value>
        /// The department.
        /// </value>
        public string Department { get; set; }

        /// <summary>
        /// Gets or sets the medical speciality.
        /// </summary>
        /// <value>
        /// The medical speciality .
        /// </value>
        public string MedSpeciality { get; set; }

        /// <summary>
        /// Gets or sets the medical subspeciality.
        /// </summary>
        /// <value>
        /// The medical sub speciality .
        /// </value>
        public string SubSpeciality { get; set; }

        /// <summary>
        /// Gets or sets the medical license.
        /// </summary>
        /// <value>
        /// The medical medical licencense .
        /// </value>
        public string MedLicense { get; set; }

        /// <summary>
        /// Gets or sets the state speciality.
        /// </summary>
        /// <value>
        /// The state license .
        /// </value>
        public string StatesLicensed { get; set; }

        /// <summary>
        /// Gets or sets the Schmedicine.
        /// </summary>
        /// <value>
        /// The Schmedicine .
        /// </value>
        public string Schmedicine { get; set; }

        /// <summary>
        /// Gets or sets the Pre medical education.
        /// </summary>
        /// <value>
        /// The pre medical education .
        /// </value>
        public string PreMedEducation { get; set; }

        /// <summary>
        /// Gets or sets the Internship .
        /// </summary>
        /// <value>
        /// The Internship value .
        /// </value>
        public string Internship { get; set; }

        /// <summary>
        /// Gets or sets the doctor Residency .
        /// </summary>
        /// <value>
        /// The Residency value .
        /// </value>
        public string Residency { get; set; }

        /// <summary>
        /// Gets or sets the Bussiness address.
        /// </summary>
        /// <value>
        /// The Bussiness address value .
        /// </value>
        public string BussAddress { get; set; }

        /// <summary>
        /// Gets or sets the time zone id.
        /// </summary>
        /// <value>
        /// The Time zone Id.
        /// </value>
        public int? TimeZoneID { get; set; }

        /// <summary>
        /// Gets or sets the gender.
        /// </summary>
        /// <value>
        /// The gender: "M" for Male, "F" for Female.
        /// </value>
        public string Gender { get; set; }

        /// <summary>
        /// Gets or sets the state registration.
        /// </summary>
        /// <value>
        /// The registration year.
        /// </value>
        public string YearOfStateRegistration { get; set; }

        /// <summary>
        /// Gets or sets the Role.
        /// </summary>
        /// <value>
        /// The activities role.
        /// </value>
        public string Roles { get; set; }

        /// <summary>
        /// Gets or sets the tags.
        /// </summary>
        /// <value>
        /// The activities tags.
        /// </value>
        public string Tags { get; set; }

        /// <summary>
        /// Set the profile validation.
        /// </summary>
        /// <value>
        /// return profile validation collection.
        /// </value>
        public IEnumerable<string> ValidateProfile()
        {
            var errors = new List<string>();
            if (PhNumber.Length > 15 || CellNumber.Length > 15)
            {
                errors.Add("The length of the Phone must be 15 characters or less");
            }

            DateTime dob;
            if (!string.IsNullOrEmpty(DOB) && !DateTime.TryParse(DOB, out dob))
            {
                errors.Add("Invalid DOB. Value: " + DOB);
            }

            return errors;
        }
    }
}