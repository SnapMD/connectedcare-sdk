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
using SnapMD.ConnectedCare.Sdk.Models;

namespace SnapMD.ConnectedCare.ApiModels
{
    public class ConsultationResult
    {
        public ResponseObservableItem AssignedDoctor { get; set; }

        public string ConferenceKey { get; set; }

        public ConsultationStatusCode ConsultationStatus { get; set; }

        public int HospitalId { get; set; }

        public int Id { get; set; }

        public string IsScheduled { get; set; }

        public string Note { get; set; }

        public ResponseObservableItem Patient { get; set; }

        public string PhoneNumber { get; set; }

        public ResponseObservableItem ResponsibleUser { get; set; }

        public DateTime? Time { get; set; }
    }
}
