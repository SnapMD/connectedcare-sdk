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

using System.Collections.Generic;
using SnapMD.VirtualCare.Sdk.Models;
using SnapMD.VirtualCare.ApiModels.Scheduling;

namespace SnapMD.VirtualCare.ApiModels
{
    /// <summary>
    /// Intake Request for OnDemand Consultation
    /// </summary>
    public class OnDemandIntakeRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OnDemandIntakeRequest"/> class
        /// </summary>
        public OnDemandIntakeRequest()
        {
            Concerns = new List<IntakeConcern>();
        }

        /// <summary>
        /// Gets or sets the concerns.
        /// </summary>
        /// <value>
        /// The concerns.
        /// </value>
        public List<IntakeConcern> Concerns { get; set; }
        /// <summary>
        /// Gets or sets the phone.
        /// </summary>
        /// <value>
        /// The phone.
        /// </value>
        public string Phone { get; set; }
        /// <summary>
        /// The type of location or phone number.
        /// </summary>
        /// <value>
        /// The phone type.
        /// </value>
        public string PhoneType { get; set; }
        /// <summary>
        /// Gets or sets the patient identifier.
        /// </summary>
        /// <value>
        /// The patient identifier.
        /// </value>
        public int PatientId { get; set; }

        /// <summary>
        /// Gets or sets encounter type code
        /// </summary>
        /// <value>
        /// EncounterTypeCode
        /// </value>
        public EncounterTypeCode? EncounterTypeCode { get; set; }
    }
}
