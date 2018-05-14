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
    /// A class encaptulating information about providers.
    /// </summary>
    public abstract class ProviderBase
    {
        /// <summary>
        /// The address of the provider.
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// The provider telephone number used for appointments.
        /// </summary>
        public string AppointmentsContactNumber { get; set; }

        /// <summary>
        /// The colors used in the provider's brand.
        /// </summary>
        public string BrandColor { get; set; }

        /// <summary>
        /// The name of the provider's brand.
        /// </summary>
        public string BrandName { get; set; }

        /// <summary>
        /// The title of the provider's brand.
        /// </summary>
        public string BrandTitle { get; set; }

        /// <summary>
        /// The amount the provider charges for a consultation.
        /// </summary>
        public double? ConsultationCharge { get; set; }

        /// <summary>
        /// The provider contact telephone number.
        /// </summary>
        public string ContactNumber { get; set; }

        /// <summary>
        /// The provider's email address.
        /// </summary>
        public string Email { get; set; }
        
        /// <summary>
        /// The provider's IT department contact number.
        /// </summary>
        public string ITDepartmentContactNumber { get; set; }

        /// <summary>
        /// The locale of the provider.
        /// </summary>
        public string Locale { get; set; }

        /// <summary>
        /// The DefaultCountry of the provider.
        /// </summary>
        public string DefaultCountry { get; set; }

        /// <summary>
        /// The Currency of the provider.
        /// </summary>
        public Currency Currency { get; set; }

        /// <summary>
        /// The state the provider resides in.
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// The numeric ID of the state the provider resides in.
        /// </summary>
        public int? StateId { get; set; }
    }
}
