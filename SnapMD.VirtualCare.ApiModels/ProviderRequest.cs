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
    ///     Provider data suitable for POST or PUT requests.
    /// </summary>
    /// <seealso cref="SnapMD.VirtualCare.ApiModels.ProviderBase" />
    public class ProviderRequest : ProviderBase
    {
        /// <summary>
        ///     Gets or sets the application URL.
        /// </summary>
        /// <value>
        ///     The application URL.
        /// </value>
        public string ApplicationUrl { get; set; }

        /// <summary>
        ///     Gets or sets the contact person.
        /// </summary>
        /// <value>
        ///     The contact person.
        /// </value>
        public PersonRecord ContactPerson { get; set; }

        /// <summary>
        ///     Gets or sets the content of the image.
        /// </summary>
        /// <value>
        ///     The content of the image.
        /// </value>
        public byte[] ImageContent { get; set; }

        /// <summary>
        ///     Gets or sets the image URL.
        /// </summary>
        /// <value>
        ///     The image URL.
        /// </value>
        public string ImageUrl { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether this instance is active.
        /// </summary>
        /// <value>
        ///     <c>true</c> if this instance is active; otherwise, <c>false</c>.
        /// </value>
        public bool IsActive { get; set; }

        /// <summary>
        ///     Gets or sets the provider code.
        /// </summary>
        /// <value>
        ///     The provider code.
        /// </value>
        public string ProviderCode { get; set; }

        /// <summary>
        ///     Gets or sets the name of the provider.
        /// </summary>
        /// <value>
        ///     The name of the provider.
        /// </value>
        public string ProviderName { get; set; }
    }
}
