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

using System;

namespace SnapMD.VirtualCare.ApiModels
{
    ///<summary>
    /// Encapsulate the ScheduleSlot.
    /// </summary>
    public class ScheduleSlot
    {
        ///<summary>
        ///Get or set the ScheduleSlotId.
        /// </summary>
        /// <value>Schedule Slot Id</value>
        public int ScheduleSlotId { get; set; }
        ///<summary>
        ///Get or set the HospitalId.
        /// </summary>
        /// <value>Hospital Id</value>
        public int HospitalId { get; set; }
        ///<summary>
        ///Get or set the DocUserId.
        /// </summary>
        /// <value>Doc User Id</value>
        public int DocUserId { get; set; }
        ///<summary>
        ///Get or set the Slot Date.
        /// </summary>
        /// <value>Slot Dated</value>
        public DateTime SlotDate { get; set; }
        ///<summary>
        ///Get or set the Slot Start Time.
        /// </summary>
        /// <value>Slot Start Timed</value>
        public DateTime? SlotStartTime { get; set; }
        ///<summary>
        ///Get or set the Slot End Time.
        /// </summary>
        /// <value>Slot End Time</value>
        public DateTime? SlotEndTime { get; set; }
        ///<summary>
        ///Get or set the Slot Status.
        /// </summary>
        /// <value>Slot Status</value>
        public string SlotStatus { get; set; }
    }
}
