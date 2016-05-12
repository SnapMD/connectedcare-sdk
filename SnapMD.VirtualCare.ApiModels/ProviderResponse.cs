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

namespace SnapMD.VirtualCare.ApiModels
{
    /// <summary>
    ///     Provider data model for API responses.
    /// </summary>
    /// <seealso cref="SnapMD.VirtualCare.ApiModels.ProviderRequest" />
    public class ProviderResponse : ProviderRequest
    {
        /// <summary>
        ///     Gets or sets the enabled modules.
        /// </summary>
        /// <value>
        ///     The enabled modules.
        /// </value>
        public List<string> EnabledModules { get; set; }

        /// <summary>
        ///     Gets or sets the hospital identifier.
        /// </summary>
        /// <value>
        ///     The hospital identifier.
        /// </value>
        public int ProviderId { get; set; }

        /// <summary>
        ///     Gets or sets the settings.
        /// </summary>
        /// <value>
        ///     The settings.
        /// </value>
        public IDictionary<string, string> Settings { get; set; }

        /// <summary>
        ///     Gets or sets the sso settings.
        /// </summary>
        /// <value>
        ///     The sso settings.
        /// </value>
        public SsoSettings SsoSettings { get; set; } = new SsoSettings();
    }
}
