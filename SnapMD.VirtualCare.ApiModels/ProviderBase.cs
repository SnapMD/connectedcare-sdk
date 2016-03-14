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
    ///     Base class for providers
    /// </summary>
    public abstract class ProviderBase
    {
        /// <summary>
        ///     Gets or sets the address.
        /// </summary>
        /// <value>
        ///     The address.
        /// </value>
        public string Address { get; set; }

        /// <summary>
        ///     Gets or sets the appointments contact number.
        /// </summary>
        /// <value>
        ///     The appointments contact number.
        /// </value>
        public string AppointmentsContactNumber { get; set; }

        /// <summary>
        ///     Gets or sets the color of the brand.
        /// </summary>
        /// <value>
        ///     The color of the brand.
        /// </value>
        public string BrandColor { get; set; }

        /// <summary>
        ///     Gets or sets the name of the brand.
        /// </summary>
        /// <value>
        ///     The name of the brand.
        /// </value>
        public string BrandName { get; set; }

        /// <summary>
        ///     Gets or sets the brand title.
        /// </summary>
        /// <value>
        ///     The brand title.
        /// </value>
        public string BrandTitle { get; set; }

        /// <summary>
        ///     Gets or sets the consultation charge.
        /// </summary>
        /// <value>
        ///     The consultation charge.
        /// </value>
        public double? ConsultationCharge { get; set; }

        /// <summary>
        ///     Gets or sets the contact number.
        /// </summary>
        /// <value>
        ///     The contact number.
        /// </value>
        public string ContactNumber { get; set; }

        /// <summary>
        ///     Gets or sets the email.
        /// </summary>
        /// <value>
        ///     The email.
        /// </value>
        public string Email { get; set; }
        
        /// <summary>
        ///     Gets or sets it department contact number.
        /// </summary>
        /// <value>
        ///     It department contact number.
        /// </value>
        public string ITDepartmentContactNumber { get; set; }

        /// <summary>
        ///     Gets or sets the locale.
        /// </summary>
        /// <value>
        ///     The locale.
        /// </value>
        public string Locale { get; set; }

        /// <summary>
        ///     Gets or sets the state.
        /// </summary>
        /// <value>
        ///     The state.
        /// </value>
        public string State { get; set; }

        /// <summary>
        ///     Gets or sets the state identifier.
        /// </summary>
        /// <value>
        ///     The state identifier.
        /// </value>
        public int? StateId { get; set; }
    }
}
