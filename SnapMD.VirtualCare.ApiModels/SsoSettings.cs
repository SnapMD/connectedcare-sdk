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

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SnapMD.VirtualCare.ApiModels
{
    /// <summary>
    ///     Holds settings for Provider's SSO options.
    /// </summary>
    public class SsoSettings
    {
        /// <summary>
        ///     Gets or sets the patient login.
        /// </summary>
        /// <value>
        ///     The patient login.
        /// </value>
        public string PatientLogin { get; set; }

        /// <summary>
        ///     Gets or sets the patient consult end URL.
        /// </summary>
        /// <value>
        ///     The patient consult end URL.
        /// </value>
        public string PatientConsultEndUrl { get; set; }

        /// <summary>
        ///     Gets or sets the customer sso type.
        /// </summary>
        /// <value>
        ///     The customer sso type.
        /// </value>
        [JsonConverter(typeof (StringEnumConverter))]
        public CustomerSsoType CustomerSso { get; set; }

        /// <summary>
        ///     Gets or sets the customer sso link text.
        /// </summary>
        /// <value>
        ///     The customer sso link text.
        /// </value>
        public string CustomerSsoLinkText { get; set; }

        /// <summary>
        /// Gets or sets the clinician login.
        /// </summary>
        /// <value>
        /// The clinician login.
        /// </value>
        public string ClinicianLogin { get; set; }

        /// <summary>
        /// Gets or sets the clinician consult end URL.
        /// </summary>
        /// <value>
        /// The clinician consult end URL.
        /// </value>
        public string ClinicianConsultEndUrl { get; set; }

        /// <summary>
        /// Gets or sets the clinician sso.
        /// </summary>
        /// <value>
        /// The clinician sso.
        /// </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public CustomerSsoType ClinicianSso { get; set; }

        /// <summary>
        /// Gets or sets the clinician sso link text.
        /// </summary>
        /// <value>
        /// The clinician sso link text.
        /// </value>
        public string ClinicianSsoLinkText { get; set; }

        /// <summary>
        /// Gets or sets the admin login.
        /// </summary>
        /// <value>
        /// The admin login.
        /// </value>
        public string AdminLogin { get; set; }

        /// <summary>
        /// Gets or sets the admin consult end URL.
        /// </summary>
        /// <value>
        /// The admin consult end URL.
        /// </value>
        public string AdminConsultReturnUrl { get; set; }

        /// <summary>
        /// Gets or sets the admin sso.
        /// </summary>
        /// <value>
        /// The admin sso.
        /// </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public CustomerSsoType AdminSso { get; set; }

        /// <summary>
        /// Gets or sets the admin sso link text.
        /// </summary>
        /// <value>
        /// The admin sso link text.
        /// </value>
        public string AdminSsoLinkText { get; set; }

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
    }
}
