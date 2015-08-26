#region Copyright
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
#endregion

using System;

namespace SnapMD.ConnectedCare.ApiModels
{
    public class FamilyMember
    {
        public int PatientId { get; set; }
        public string PatientName { get; set; }
        public string ProfileImagePath { get; set; }
        public int RelationCode { get; set; }
        public bool IsAuthorized { get; set; }
        public DateTime? Birthdate { get; set; }
        public string[] Addresses { get; set; }
        public string PatientFirstName { get; set; }
        public string PatientLastName { get; set; }
        public string GuardianFirstName { get; set; }
        public string GuardianLastName { get; set; }
        public string GuardianName { get; set; }
    }
}
