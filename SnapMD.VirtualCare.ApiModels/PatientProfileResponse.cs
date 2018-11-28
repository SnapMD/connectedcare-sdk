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

namespace SnapMD.VirtualCare.ApiModels
{
    /// <summary>
    /// Represents Patient Profile Response.
    /// </summary>
    public class PatientProfileResponse
    {
        /// <summary>
        /// Get or set the Patient Id
        /// </summary>
        /// <value>
        /// PatientId
        /// </value>
        public int PatientId { get; set; }

        /// <summary>
        /// Get or set the Security Token
        /// </summary>
        /// <value>
        /// Security Token
        /// </value>
        public string SecurityToken { get; set; }
        /// <summary>
        /// Get or set the Patient Name
        /// </summary>
        /// <value>
        /// Patient Name
        /// </value>
        public string PatientName { get; set; }
        /// <summary>
        /// Get or set the LastName
        /// </summary>
        /// <value>
        /// LastName
        /// </value>
        public string LastName { get; set; }
        /// <summary>
        /// Get or set the Mobile Phone
        /// </summary>
        /// <value>
        /// MobilePhone
        /// </value>
        public string MobilePhone { get; set; }
        /// <summary>
        /// Get or set the Profile Image Path
        /// </summary>
        /// <value>
        /// ProfileImagePath
        /// </value>
        public string ProfileImagePath { get; set; }
        /// <summary>
        /// Get or set the HomePhone
        /// </summary>
        /// <value>
        /// HomePhone
        /// </value>
        public string HomePhone { get; set; }
        /// <summary>
        /// Get or set the Primary Physician
        /// </summary>
        /// <value>
        /// Primary Physician
        /// </value>
        public string PrimaryPhysician { get; set; }
        /// <summary>
        /// Get or set the Primary Physician Contact
        /// </summary>
        /// <value>
        /// PrimaryPhysicianContact
        /// </value>
        public string PrimaryPhysicianContact { get; set; }
        /// <summary>
        /// Get or set the PhysicianSpecialist
        /// </summary>
        /// <value>
        /// PhysicianSpecialist
        /// </value>
        public string PhysicianSpecialist { get; set; }
        /// <summary>
        /// Get or set the PhysicianSpecialistContact
        /// </summary>
        /// <value>
        /// PhysicianSpecialistContact
        /// </value>
        public string PhysicianSpecialistContact { get; set; }
        /// <summary>
        /// Get or set the Organization
        /// </summary>
        /// <value>
        /// Organization
        /// </value>
        public string Organization { get; set; }
        /// <summary>
        /// Get or set the Location
        /// </summary>
        /// <value>
        /// Location
        /// </value>
        public string Location { get; set; }
        /// <summary>
        /// Get or set the OrganizationId
        /// </summary>
        /// <value>
        /// OrganizationId
        /// </value>
        public int? OrganizationId { get; set; }
        /// <summary>
        /// Get or set the LocationId
        /// </summary>
        /// <value>
        /// LocationId
        /// </value>
        public int? LocationId { get; set; }

        /* Add more in the future */

    }
}
