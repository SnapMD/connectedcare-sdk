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
    public class PatientProfilesResult
    {
        /// <summary>
        /// Get or set the Profile Id
        /// </summary>
        /// <value>
        /// ProfileId
        /// </value>
        public int? ProfileId { get; set; }
        /// <summary>
        /// Get or set the Hospital Id
        /// </summary>
        /// <value>
        /// HospitalId
        /// </value>
        public int HospitalId { get; set; }
        /// <summary>
        /// Get or set the FirstName
        /// </summary>
        /// <value>
        /// FirstName
        /// </value>
        public string FirstName { get; set; }
        /// <summary>
        /// Get or set the LastName
        /// </summary>
        /// <value>
        /// LastName
        /// </value>
        public string LastName { get; set; }
        /// <summary>
        /// Get or set the Gender
        /// </summary>
        /// <value>
        /// Gender
        /// </value>
        public string Gender { get; set; }
        /// <summary>
        /// Get or set the Profile Image Path
        /// </summary>
        /// <value>
        /// ProfileImagePath
        /// </value>
        public string ProfileImagePath { get; set; }
        /// <summary>
        /// Get or set the Dob
        /// </summary>
        /// <value>
        /// Dob
        /// </value>
        public string Dob { get; set; }
    }
}