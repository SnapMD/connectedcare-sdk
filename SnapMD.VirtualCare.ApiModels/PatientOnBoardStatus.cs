﻿//    Copyright 2016 SnapMD, Inc.
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
    /// Represents the Patient On Board Status.
    /// </summary>
    public enum PatientOnBoardStatus
    {
        /// <summary>
        /// Enumaration code None value 0
        /// </summary>
        None = 0,
        /// <summary>
        /// Enumaration code Active value 1
        /// </summary>
        Active = 1,
        /// <summary>
        /// Enumaration code Inactive value -1
        /// </summary>
        Inactive = -1
    }
}