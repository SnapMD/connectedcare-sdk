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
    /// Represents patient account information details.
    /// </summary>
    public class PatientAccountInfo
    {
        /// <summary>
        ///     Gets or sets the Patient Id.
        /// </summary>
        /// <value>
        ///     PatientId.
        /// </value>
        public int PatientId { get; set; }
        /// <summary>
        ///     Gets or sets the User Id.
        /// </summary>
        /// <value>
        ///     UserId.
        /// </value>
        public int? UserId { get; set; }
        /// <summary>
        ///     Gets or sets the Profile Image Path.
        /// </summary>
        /// <value>
        ///     ProfileImagePath.
        /// </value>
        public string ProfileImagePath { get; set; }
        /// <summary>
        ///     Gets or sets the Full Name.
        /// </summary>
        /// <value>
        ///     FullName.
        /// </value>
        public string FullName { get; set; }
        /// <summary>
        ///     Gets or sets the Patient First Name.
        /// </summary>
        /// <value>
        ///     FirstName.
        /// </value>
        public string FirstName { get; set; }
        /// <summary>
        ///     Gets or sets the Patient Last Name.
        /// </summary>
        /// <value>
        ///     LastName.
        /// </value>
        public string LastName { get; set; }
        /// <summary>
        ///     Gets or sets the Patient Last Phone.
        /// </summary>
        /// <value>
        ///     Phone.
        /// </value>
        public string Phone { get; set; }
        /// <summary>
        ///     Gets or sets the Date of birth.
        /// </summary>
        /// <value>
        ///     DOB.
        /// </value>
        public string Dob { get; set; }
        /// <summary>
        ///     Gets or sets the patient Age.
        /// </summary>
        /// <value>
        ///     Age.
        /// </value>
        public int? Age { get; set; }
        /// <summary>
        ///     Gets or sets the patient is authorized.
        /// </summary>
        /// <value>
        ///     IsAuthorized.
        /// </value>
        public bool IsAuthorized { get; set; }
        /// <summary>
        ///     Gets or sets the patient account Status.
        /// </summary>
        /// <value>
        ///    Active = 1,
        ///    Inactive = 0,
        ///    Pending = 2     
        /// </value>
        public PatientAccountStatus Status { get; set; }
        /// <summary>
        ///     Gets or sets the patient Gender.
        /// </summary>
        /// <value>
        ///     Male,Female,Other.
        /// </value>
        public string Gender { get; set; }
        /// <summary>
        ///     Gets or sets the patient Is Dependent.
        /// </summary>
        /// <value>
        ///    True or False
        /// </value>
        public bool IsDependent { get; set; }
        /// <summary>
        ///     Gets or sets the GuardianId.
        /// </summary>
        /// <value>
        ///   Nullable GuardianId
        /// </value>
        public int? GuardianId { get; set; }
        /// <summary>
        ///     Gets or sets the Patinet Email.
        /// </summary>
        /// <value>
        ///   Email
        /// </value>
        public string Email { get; set; }
        /// <summary>
        ///     Gets or sets the PersonId.
        /// </summary>
        /// <value>
        ///   PersonId
        /// </value>
        public Guid PersonId { get; set; }
        /// <summary>
        ///     Gets or sets the Family GroupId.
        /// </summary>
        /// <value>
        ///   FamilyGroupId
        /// </value>
        public int FamilyGroupId { get; set; }
        /// <summary>
        ///     Gets or sets the Ethnicity Id.
        /// </summary>
        /// <value>
        ///   EthnicityId
        /// </value>
        public int? EthnicityId { get; set; }
        /// <summary>
        ///     Gets or sets the Ethnicity Name.
        /// </summary>
        /// <value>
        ///   EthnicityName
        /// </value>
        public string EthnicityName { get; set; }
        /// <summary>
        ///     Gets or sets the OrganizationId.
        /// </summary>
        /// <value>
        ///   OrganizationId
        /// </value>
        public int? OrganizationId { get; set; }
        /// <summary>
        ///     Gets or sets the Organization Name.
        /// </summary>
        /// <value>
        ///   OrganizationName
        /// </value>
        public string OrganizationName { get; set; }
        /// <summary>
        ///     Gets or sets the Location Id.
        /// </summary>
        /// <value>
        ///   LocationId
        /// </value>
        public int? LocationId { get; set; }
        /// <summary>
        ///     Gets or sets the Location Name.
        /// </summary>
        /// <value>
        ///   LocationName
        /// </value>
        public string LocationName { get; set; }
        /// <summary>
        ///     Gets or sets the GroupsIds.
        /// </summary>
        /// <value>
        ///   GroupsIds
        /// </value>
        public int[] GroupsIds { get; set; }

        /// <summary>
        /// Is the user patient (true) or NPU (false)
        /// </summary>
        public bool IsPatient { get; set; }
    }
}
