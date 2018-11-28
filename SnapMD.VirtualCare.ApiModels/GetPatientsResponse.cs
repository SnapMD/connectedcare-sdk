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
namespace SnapMD.VirtualCare.ApiModels
{

    /// <summary>
    ///     Items representing the person's identity.
    /// </summary>
    public class GetPatientsResponse
    {
        /// <summary>
        ///     Gets or sets the Patient Name.
        /// </summary>
        /// <value>
        ///     The Patient Name.
        /// </value>
        public string PatientName { get; set; }
        /// <summary>
        ///     Gets or sets the LastName.
        /// </summary>
        /// <value>
        ///     The Last Name.
        /// </value>
        public string LastName { get; set; }
        /// <summary>
        ///     Gets or sets the MobilePhone.
        /// </summary>
        /// <value>
        ///     The MobilePhone.
        /// </value>
        public string MobilePhone { get; set; }
        /// <summary>
        ///     Gets or sets the ProfileImagePath.
        /// </summary>
        /// <value>
        ///     The Profile Image Path.
        /// </value>
        public string ProfileImagePath { get; set; }
        /// <summary>
        ///     Gets or sets the HomePhone.
        /// </summary>
        /// <value>
        ///     The Profile Home Phone.
        /// </value>
        public string HomePhone { get; set; }
        /// <summary>
        ///     Gets or sets the Primary Physician.
        /// </summary>
        /// <value>
        ///     The PrimaryPhysician.
        /// </value>
        public string PrimaryPhysician { get; set; }
        /// <summary>
        ///     Gets or sets the Primary Physician.
        /// </summary>
        /// <value>
        ///     The PrimaryPhysician.
        /// </value>
        public string PrimaryPhysicianContact { get; set; }
        /// <summary>
        ///     Gets or sets the Physician Specialist.
        /// </summary>
        /// <value>
        ///     The PhysicianSpecialist.
        /// </value>
        public string PhysicianSpecialist { get; set; }
        /// <summary>
        ///     Gets or sets the Physician SpecialistContact.
        /// </summary>
        /// <value>
        ///     The PhysicianSpecialistContact.
        /// </value>
        public string PhysicianSpecialistContact { get; set; }
        /// <summary>
        ///     Gets or sets the Organization.
        /// </summary>
        /// <value>
        ///     The Organization.
        /// </value>
        public string Organization { get; set; }
        /// <summary>
        ///     Gets or sets the Location.
        /// </summary>
        /// <value>
        ///     The Location.
        /// </value>
        public string Location { get; set; }
        /// <summary>
        ///     Gets or sets the Organization Id.
        /// </summary>
        /// <value>
        ///     The OrganizationId.
        /// </value>
        public int? OrganizationId { get; set; }
        /// <summary>
        ///     Gets or sets the Location Id.
        /// </summary>
        /// <value>
        ///     The LocationId.
        /// </value>
        public int? LocationId { get; set; }
        /// <summary>
        ///     Gets or sets the Groups.
        /// </summary>
        /// <value>
        ///     The Groups.
        /// </value>
        public PatientGroup[] Groups { get; set; }

        /// <summary>
        ///     Gets or sets the Patient Group.
        /// </summary>
        /// <value>
        ///     The PatientGroup.
        /// </value>
        public class PatientGroup
        {
            /// <summary>
            ///     Gets or sets the Patient Id.
            /// </summary>
            /// <value>
            ///     The Id.
            /// </value>
            public int Id { get; set; }
            /// <summary>
            ///     Gets or sets the Patient Name.
            /// </summary>
            /// <value>
            ///     The Patient Name.
            /// </value>
            public string Name { get; set; }
            /// <summary>
            ///     Gets or sets the Patient Description.
            /// </summary>
            /// <value>
            ///     The Patient Description.
            /// </value>
            public string Description { get; set; }
            /// <summary>
            ///     Gets or sets the Parent GroupId.
            /// </summary>
            /// <value>
            ///     The Patient ParentGroupId.
            /// </value>
            public int? ParentGroupId { get; set; }
        }
    }

}