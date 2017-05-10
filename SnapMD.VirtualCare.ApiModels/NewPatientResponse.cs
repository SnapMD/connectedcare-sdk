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

namespace SnapMD.VirtualCare.ApiModels
{
    public class NewPatientResponse
    {
        public string Address { get; set; }

        public DateTime? Dob { get; set; }
        
        public int TimeZoneId { get; set; }

        public string Email { get; set; }

        public FirstLast Name { get; set; }

        public int PatientId { get; set; }

        public int ProviderId { get; set; }

        public int UserLoginId { get; set; }

        public string Gender { get; set; }

        public string MobilePhone { get; set; }
    }
}
