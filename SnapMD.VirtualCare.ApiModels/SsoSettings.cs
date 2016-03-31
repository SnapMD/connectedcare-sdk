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
    }
}
