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
    /// Encapsultae the Hospital Address
    /// </summary>
    [Serializable]
    public class HospitalAddress
    {
        /// <summary>
        ///     Gets or sets the Hospital Id.
        /// </summary>
        /// <value>
        ///     The Hospital Id.
        /// </value>
        public int HospitalId { get; set; }
        /// <summary>
        ///     Gets or sets the Hospital Adress.
        /// </summary>
        /// <value>
        ///     The Hospital Address.
        /// </value>
        public string Address { get; set; }
        /// <summary>
        ///     Gets or sets the Adress Objects.
        /// </summary>
        /// <value>
        ///     1.Line1.
        ///     2.Line2
        ///     3.City
        ///     4.State
        ///     5.StateCode
        ///     6.PostalCode
        ///     7.Country
        ///     8.CountryCode
        ///     8.AddressTest
        /// </value>
        public AddressObject AddressObject { get; set; }
    }
}
