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
    /// Different types of rules presence (visibility, registration etc.)
    /// </summary>
    public class RulesStatus
    {
        /// <summary>
        /// Is patient's home address used in visibility rules?
        /// </summary>
        public bool HomeAddressRuleActive { get; set; }

        /// <summary>
        /// Is patient's response address used in visibility rules?
        /// </summary>
        public bool ResponseAddressRuleActive { get; set; }

        /// <summary>
        /// Is any of the patient's registration rules active?
        /// </summary>
        public bool RegistrationRuleActive { get; set; }
    }
}
