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
    /// Encapsulate Patient Short Information
    /// </summary>
    public class PatientShortInfo
    {
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        /// <value>
        /// Patient Short Id.
        /// </value>
        public int Id { get; set; }
        /// <summary>
        /// Gets or sets the Primary Physician.
        /// </summary>
        /// <value>
        /// Primary Physician.
        /// </value>
        public string PrimaryPhysician { get; set; }
        /// <summary>
        /// Gets or sets the Primary Physician Name.
        /// </summary>
        /// <value>
        /// Primary Physician Name.
        /// </value>
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the Primary Physician Address.
        /// </summary>
        /// <value>
        /// Primary Physician Address.
        /// </value>
        public string Address { get; set; }
        /// <summary>
        /// Gets or sets the Primary Physician City.
        /// </summary>
        /// <value>
        /// Primary Physician City.
        /// </value>
        public string City { get; set; }
        /// <summary>
        /// Gets or sets the Primary Physician Zip Code.
        /// </summary>
        /// <value>
        /// Primary Physician Zip Code.
        /// </value>
        public string ZipCode { get; set; }

        /// <summary>
        /// Gets or sets the gender.
        /// </summary>
        /// <value>
        /// The gender: "M" for Male, "F" for Female.
        /// </value>
        public string Gender { get; set; }
        /// <summary>
        /// Gets or sets the Primary Physician Date of Birth.
        /// </summary>
        /// <value>
        /// Primary Physician Date of Birth.
        /// </value>
        public DateTime? Dob { get; set; }
    }
}