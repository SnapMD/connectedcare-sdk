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

namespace SnapMD.VirtualCare.ApiModels
{
    /// <summary>
    /// Represents patient account status.
    /// </summary>
    public enum PatientAccountStatus
    {
        /// <summary>
        ///     Enum data Active .
        /// </summary>
        /// <value>
        ///     1.
        /// </value> 
        Active = 1,
        /// <summary>
        ///     Enum data Inactive .
        /// </summary>
        /// <value>
        ///     0.
        /// </value> 
        Inactive = 0,
        /// <summary>
        ///     Enum data Pending .
        /// </summary>
        /// <value>
        ///     2.
        /// </value> 
        Pending = 2
    }
}
