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
    ///     Items representing the person's identity.
    /// </summary>
    public class FamilyMember
    {
        /// <summary>
        ///     Gets or sets the patient Id.
        /// </summary>
        /// <value>
        ///     The Patient Id.
        /// </value>
        public int PatientId { get; set; }
        /// <summary>
        ///     Gets or sets the patient Name.
        /// </summary>
        /// <value>
        ///     The Patient Name.
        /// </value>
        public string PatientName { get; set; }
        /// <summary>
        ///     Gets or sets the patient profile images path.
        /// </summary>
        /// <value>
        ///     The Profile Image Path.
        /// </value>
        public string ProfileImagePath { get; set; }
        /// <summary>
        ///     Gets or sets the personImageId.
        /// </summary>
        /// <value>
        ///     The Person Image Id.
        /// </value>
        public Guid? PersonImageId { get; set; }
        /// <summary>
        ///     Gets or sets the Relation Code.
        /// </summary>
        /// <value>
        ///     The RelationCode.
        /// </value>
        public int RelationCode { get; set; }
        /// <summary>
        ///     Gets or sets the Person is authorized.
        /// </summary>
        /// <value>
        ///   true or false.
        /// </value>
        public bool IsAuthorized { get; set; }
        /// <summary>
        ///     Gets or sets the Birth Date.
        /// </summary>
        /// <value>
        ///  Date of the birth.
        /// </value>
        public DateTime? Birthdate { get; set; }
        /// <summary>
        ///   Get or set the  Patient Address.
        /// </summary>
        /// <value>
        ///  Patient Address.
        /// </value>
        public string[] Addresses { get; set; }
        /// <summary>
        ///   Get or set the  Patient Address.
        /// </summary>
        /// <value>
        ///  Patient Address.
        /// </value>
        public string PatientFirstName { get; set; }
        /// <summary>
        ///   Get or set the  Patient Last Name.
        /// </summary>
        /// <value>
        ///  Patient Last Name.
        /// </value>
        public string PatientLastName { get; set; }
        /// <summary>
        ///   Get or set the  Guardian First Name.
        /// </summary>
        /// <value>
        ///  GuardianFirstName.
        /// </value>
        public string GuardianFirstName { get; set; }
        /// <summary>
        ///   Get or set the  Guardian First Name.
        /// </summary>
        /// <value>
        ///  GuardianFirstName.
        /// </value>
        public string GuardianLastName { get; set; }
        /// <summary>
        ///   Get or set the  Guardian Name.
        /// </summary>
        /// <value>
        ///  GuardianName.
        /// </value>
        public string GuardianName { get; set; }
        /// <summary>
        ///   Get or set the  Person Id.
        /// </summary>
        /// <value>
        ///  Guid.
        /// </value>
        public Guid? PersonId { get; set; }
        /// <summary>
        ///   Get or set the  Email Id.
        /// </summary>
        /// <value>
        ///  EmailId.
        /// </value>
        public string EmailId { get; set; }
        /// <summary>
        ///   Get or set the  Gender.
        /// </summary>
        /// <value>
        ///  Gender.
        /// </value>
        public string Gender { get; set; }
        /// <summary>
        ///   Get or set the  Ethnicity.
        /// </summary>
        /// <value>
        ///  Ethnicity.
        /// </value>
        public int? Ethnicity { get; set; }
        /// <summary>
        ///   Get or set the  Blood Type.
        /// </summary>
        /// <value>
        ///  BloodType like O(ve-),O(ve+),AB(ve-).
        /// </value>
        public int? BloodType { get; set; }
        /// <summary>
        ///   Get or set the  Hair Color.
        /// </summary>
        /// <value>
        ///  Hair Color like Black, Brawn
        /// </value>
        public int? HairColor { get; set; }
        /// <summary>
        ///   Get or set the  Eye Color.
        /// </summary>
        /// <value>
        ///  Eye Color like Black, Brawn
        /// </value>
        public int? EyeColor { get; set; }
        /// <summary>
        ///   Get or set the  Patient.
        /// </summary>
        /// <value>
        ///  Height like 5'6",6'
        /// </value>
        public string Height { get; set; }
        /// <summary>
        ///   Get or set the  Weight.
        /// </summary>
        /// <value>
        ///  Weight
        /// </value>
        public string Weight { get; set; }
        /// <summary>
        ///   Get or set the  Height Unit.
        /// </summary>
        /// <value>
        ///  HeightUnit
        /// </value>
        public int? HeightUnit { get; set; }
        /// <summary>
        ///   Get or set the  WeightUnit.
        /// </summary>
        /// <value>
        ///  WeightUnit
        /// </value>
        public int? WeightUnit { get; set; }
        /// <summary>
        ///   Get or set the  HomePhone.
        /// </summary>
        /// <value>
        ///  WeightUnit
        /// </value>
        public string HomePhone { get; set; }
        /// <summary>
        ///   Get or set the  MobilePhone.
        /// </summary>
        /// <value>
        ///  MobilePhone
        /// </value>
        public string MobilePhone { get; set; }
        /// <summary>
        ///   Get or set the  OrganationId.
        /// </summary>
        /// <value>
        ///  OrganationId
        /// </value>
        public int? OrganationId { get; set; }
        /// <summary>
        ///   Get or set the  LocationId.
        /// </summary>
        /// <value>
        ///  LocationId
        /// </value>
        public int? LocationId { get; set; }

        /// <summary>
        ///   Get or set the  ProviderAvailable.
        /// </summary>
        /// <value>
        ///  ProviderAvailable
        /// </value>
        public bool? ProviderAvailable { get; set; }
        /// <summary>
        ///   Get or set the  IsInQueue.
        /// </summary>
        /// <value>
        ///  IsInQueue
        /// </value>
        public bool? IsInQueue { get; set; }
        /// <summary>
        ///   Get or set the  Patient Consultation Status.
        /// </summary>
        /// <value>
        ///  Consultation Status
        /// </value>
        public bool? IsInConsultation { get; set; }
        /// <summary>
        ///   Get or set the  Patient Queue State.
        /// </summary>
        /// <value>
        ///  PatientQueueState
        /// </value>
        public int? PatientQueueState { get; set; }
        /// <summary>
        ///   Get or set the  Patient Queue Connected.
        /// </summary>
        /// <value>
        ///  Patient Queue Connected
        /// </value>
        public bool? PatientQueueConnected { get; set; }
        /// <summary>
        ///   Get or set the  Patient Queue Connection Time.
        /// </summary>
        /// <value>
        ///  Patient Queue Connection Time
        /// </value>
        public DateTime? PatientQueueConnectionTime { get; set; }
    }
}
