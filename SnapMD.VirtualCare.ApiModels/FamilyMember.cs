﻿#region Copyright
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
    public class FamilyMember
    {
        public int PatientId { get; set; }
        public string PatientName { get; set; }
        public string ProfileImagePath { get; set; }
        public Guid? PersonImageId { get; set; }
        public int RelationCode { get; set; }
        public bool IsAuthorized { get; set; }
        public DateTime? Birthdate { get; set; }
        public string[] Addresses { get; set; }
        public string PatientFirstName { get; set; }
        public string PatientLastName { get; set; }
        public string GuardianFirstName { get; set; }
        public string GuardianLastName { get; set; }
        public string GuardianName { get; set; }
        public Guid? PersonId { get; set; }

        public string EmailId { get; set; }
        public string Gender { get; set; }
        public int? Ethnicity { get; set; }
        public int? BloodType { get; set; }
        public int? HairColor { get; set; }
        public int? EyeColor { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public int? HeightUnit { get; set; }
        public int? WeightUnit { get; set; }
        public string HomePhone { get; set; }
        public string MobilePhone { get; set; }
        public int? OrganationId { get; set; }
        public int? LocationId { get; set; }

        public bool? ProviderAvailable { get; set; }
        public bool? IsInQueue { get; set; }
        public bool? IsInConsultation { get; set; }

        public int? PatientQueueState { get; set; }
        public bool? PatientQueueConnected { get; set; }
        public DateTime? PatientQueueConnectionTime { get; set; }
    }
}
