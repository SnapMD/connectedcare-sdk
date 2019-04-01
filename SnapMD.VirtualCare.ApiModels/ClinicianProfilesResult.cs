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

namespace SnapMD.VirtualCare.ApiModels
{
    /// <summary>
    ///     Represents public information for a clinician that is suitable for patient use.
    /// </summary>
    public class ClinicianProfilesResult
    {
        /// <summary>
        /// Get or set Profile Id
        /// </summary>
        /// <value>
        /// Profile Id
        /// </value>
        public int? ProfileId { get; set; }

        /// <summary>
        /// Get or set Clinician Id
        /// </summary>
        /// <value>
        /// Clinician Id
        /// </value>
        public int? ClinicianId { get; set; }

        /// <summary>
        /// Get or set Business Address
        /// </summary>
        /// <value>
        /// BusinessAddress
        /// </value>
        public string BusinessAddress { get; set; }

        /// <summary>
        /// Get or set FirstName
        /// </summary>
        /// <value>
        /// BusinessAddress
        /// </value>
        public string FirstName { get; set; }

        /// <summary>
        /// Get or set FullName
        /// </summary>
        /// <value>
        /// FullName
        /// </value>
        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }
        
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the gender.
        /// </summary>
        /// <value>
        /// The gender: "M" for Male, "F" for Female.
        /// </value>
        public string Gender { get; set; }

        /// <summary>
        /// Get or set LastName
        /// </summary>
        /// <value>
        /// LastName
        /// </value>
        public int HospitalId { get; set; }

        /// <summary>
        /// Get or set MedicalLicense
        /// </summary>
        /// <value>
        /// MedicalLicense
        /// </value>
        public string LastName { get; set; }

        /// <summary>
        /// Get or set MedicalSpeciality
        /// </summary>
        /// <value>
        /// MedicalSpeciality
        /// </value>
        public string MedicalLicense { get; set; }

        /// <summary>
        /// Get or set MedicalSchool
        /// </summary>
        /// <value>
        /// MedicalSchool
        /// </value>
        public string MedicalSpeciality { get; set; }

        /// <summary>
        ///     Get Doctor profile image or default one.
        /// </summary>
        public string MedicalSchool { get; set; }

        /// <summary>
        ///     Get Doctor profile image or default one.
        /// </summary>
        public string ProfileImage
        {
            get
            {
                if (!string.IsNullOrEmpty(ProfileImagePath))
                {
                    return ProfileImagePath;
                }

                return Gender == "F" ? "/images/Doctor-Female.gif" : "/images/Doctor-Male.gif";
            }
        }

        public string ProfileImagePath { get; set; }

        public string StatesLicenced { get; set; }

        public string SubSpeciality { get; set; }

        public DateTime? Dob { get; set; }
    }
}
