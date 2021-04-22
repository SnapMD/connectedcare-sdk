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

using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SnapMD.VirtualCare.ApiModels
{
    /// <summary>
    /// A class encapsulating info about a hospital.
    /// </summary>
    public class HospitalInfo : ProviderBase, IHospitalResponse
    {

        /// <summary>
        /// The enum of Field Presence.
        /// </summary>
        public enum FieldPresence {
            /// <summary>
            /// Field Presence Mandatory
            /// </summary>
            Mandatory,
            /// <summary>
            /// Field Presence Optional
            /// </summary>
            Optional,
            /// <summary>
            /// Field Presence Invisible
            /// </summary>
            Invisible
        }

        /// <summary>
        /// The city in which the hospital resides.
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// The contact person at this hospital.
        /// </summary>
        public string ContactPerson { get; set; }

        /// <summary>
        /// The level of SSO this hospital requires to access the SnapMD system.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public CustomerSsoType CustomerSso { get; set; }

        /// <summary>
        /// The link text used to allow a customer SSO access.
        /// </summary>
        public string CustomerSsoLinkText { get; set; }

        /// <summary>
        /// The list of modules enabled for a hospital.
        /// </summary>
        public List<string> EnabledModules { get; set; }

        /// <summary>
        /// Configuration of mandatory/optional/invisible fields
        /// </summary>
        public Dictionary<string, string> FieldsPresence { get; set; }

        /// <summary>
        /// Configuration of mandatory/optional/invisible fields PatientSettings
        /// </summary>
        public Dictionary<string, string> PatientSettings { get; set; }

        /// <summary>
        /// Configuration of visible/invisible fields to Patient of Provider Profile
        /// </summary>
        public Dictionary<string, bool> ProviderVisibleFields { get; set; }

        /// <summary>
        /// Configuration of mandatory/optional fields Provider Profile
        /// </summary>
        public Dictionary<string, string> ProviderProfileFields { get; set; }

        /// <summary>
        /// The hospital ID.
        /// </summary>
        public int HospitalId { get; set; }

        /// <summary>
        /// The name of the hospital.
        /// </summary>
        public string HospitalName { get; set; }

        /// <summary>
        /// Am image of the hospital.
        /// </summary>
        public string HospitalImage { get; set; }

        /// <summary>
        /// Whether the hospital is active.
        /// </summary>
        public string IsActive { get; set; }

        /// <summary>
        /// The operating hours for the provider.
        /// </summary>
        public virtual IEnumerable<HospitalHours> OperatingHours { get; set; }

        /// <summary>
        /// The domain name of the provider.
        /// </summary>
        /// <remarks>
        /// The path to the appropriate login URL must be provided when providing a link to this domain name.
        /// </remarks>
        public string HospitalDomainName { get; set; }

        /// <summary>
        /// The URL used for handling enounters through patients.
        /// </summary>
        public string PatientConsultEndUrl { get; set; }

        /// <summary>
        /// The patient's login.
        /// </summary>
        public string PatientLogin { get; set; }

        /// <summary>
        /// The dictionary of hospital settings.
        /// </summary>
        public IDictionary<string, string> Settings { get; set; }

        /// <summary>
        /// The level of SSO access required for a clinician.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public CustomerSsoType ClinicianSso { get; set; }

        /// <summary>
        /// The link text used to allow a clinician SSO access.
        /// </summary>
        public string ClinicianSsoLinkText { get; set; }

        /// <summary>
        /// The URL used for handling enounters through clinicians.
        /// </summary>
        public string ClinicianConsultEndUrl { get; set; }

        /// <summary>
        /// The clinician's login.
        /// </summary>
        public string ClinicianLogin { get; set; }

        /// <summary>
        /// The level of SSO access required for an admin.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public CustomerSsoType AdminSso { get; set; }

        /// <summary>
        /// The link text used to allow an admin SSO access.
        /// </summary>
        public string AdminSsoLinkText { get; set; }

        /// <summary>
        /// The URL used for handling encounters through admins.
        /// </summary>
        public string AdminConsultEndUrl { get; set; }

        /// <summary>
        /// The admin's login.
        /// </summary>
        public string AdminLogin { get; set; }

        /// <summary>
        /// The api endpoint patient auth token.
        /// </summary>
        public string PatientTokenApi { get; set; }

        /// <summary>
        /// The api endpoint for patient registration.
        /// </summary>
        public string PatientRegistrationApi { get; set; }

        /// <summary>
        /// The api endpoint for patient forgot password.
        /// </summary>
        public string PatientForgotPasswordApi { get; set; }

        /// <summary>
        /// Different types of rules presence (visibility, registration etc.)
        /// </summary>
        public RulesStatus RulesStatus { get; set; }

    }
}
