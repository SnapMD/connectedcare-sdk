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

using SnapMD.VirtualCare.ApiModels.Attributes;

namespace SnapMD.VirtualCare.ApiModels
{
    /// <summary>
    /// User role model.
    /// </summary>
    [ModelName("ApiModels.UserRole")]
    public class UserRole
    {
        /// <summary>
        /// Role id.
        /// </summary>
        public int RoleId { get; set; }

        /// <summary>
        /// Role description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Role status. A - active, I - inactive.
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Role code.
        /// </summary>
        public string RoleCode { get; set; }
    }
}
