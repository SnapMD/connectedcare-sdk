﻿#region Copyright
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

using System.Xml.Serialization;
using Newtonsoft.Json;

namespace SnapMD.VirtualCare.ApiModels
{

    /// <summary>
    ///     Struct representing the Encounter Concern.
    /// </summary>
    public struct EncounterConcern
    {
        private ICustomCode _customCode;


        /// <summary>
        ///     Gets or sets the Cutome Code.
        /// </summary>
        /// <value>
        ///     The CustomCode.
        /// </value>
        [XmlIgnore, JsonIgnore]
        public ICustomCode CustomCode
        {
            get
            {
                if (_customCode == null)
                {
                    _customCode = new CustomCode();
                }
                return _customCode;
            }
            set { _customCode = value; }
        }

        /// <summary>
        ///     To avoid compiler error with serializing an Interface. #3515
        /// </summary>
        [XmlElement("CustomCode"), JsonProperty("customCode")]
        public CustomCode? CustomCodeSerializable
        {
            get { return (CustomCode?)CustomCode; }
            set { CustomCode = value; }
        }

        /// <summary>
        ///     Gets or sets the status of Primary.
        /// </summary>
        /// <value>
        ///     The IsPrimary.
        /// </value>

        [XmlAttribute]
        public bool IsPrimary { get; set; }
    }
}
