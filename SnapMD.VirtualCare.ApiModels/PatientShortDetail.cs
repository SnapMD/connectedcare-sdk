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
    /// <summary>
    /// A class encapsulating Patient Short Info.
    /// </summary>
    public class PatientShortInfo
    {
        /// <summary>
        /// The id of the patient info.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// The Primary Physician info.
        /// </summary>
        /// <value>Primary Physician </value>
        public string PrimaryPhysician { get; set; }
        /// <summary>
        /// The Name of Physician.
        /// </summary>
        /// <value>Physician Name </value>                                                                                                                              </value>
        public string Name { get; set; }
        /// <summary>
        /// The Physician Address.
        /// </summary>
        /// <value>Physician Address </value>    
        public string Address { get; set; }
        /// <summary>
        /// The Physician City.
        /// </summary>
        /// <value>Physician City </value>    
        public string City { get; set; }
        /// <summary>
        /// The Physician ZipCode.
        /// </summary>
        /// <value>Zip Code </value>    
        public string ZipCode { get; set; }

        /// <summary>
        /// Gets or sets the gender.
        /// </summary>
        /// <value>
        /// The gender: "M" for Male, "F" for Female.
        /// </value>
        public string Gender { get; set; }
        /// <summary>
        /// The Physician ZipCode.
        /// </summary>
        /// <value>Zip Code </value>    
        public DateTime? Dob { get; set; }
    }
}