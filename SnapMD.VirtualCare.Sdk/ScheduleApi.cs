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

using SnapMD.VirtualCare.ApiModels;
using SnapMD.VirtualCare.Sdk.Models;
using SnapMD.VirtualCare.Sdk.Interfaces;

namespace SnapMD.VirtualCare.Sdk
{
    /// <summary>
    /// Represents the Schedule Api.
    /// </summary>
    public class ScheduleApi : ApiCall
    {
        /// <summary>
        /// Represent the ScheduleApi Constructor
        /// </summary>
        /// <param name="apiKey">Api Key</param>
        /// <param name="baseUrl"> Base Url</param>
        /// <param name="bearerToken"> Bearer Token</param>
        /// <param name="developerId"> Developer Id</param>
        /// <param name="webClient"> webClient </param>
        public ScheduleApi(string baseUrl, string bearerToken, string developerId, string apiKey, IWebClient webClient)
            : base(baseUrl, webClient, bearerToken, developerId, apiKey)
        {
        }

        /// <summary>
        /// Represent the ScheduleApi Constructor
        /// </summary>
        /// <param name="baseUrl">baseUrl</param>
        /// <param name="webClient">webClient</param>
        public ScheduleApi(string baseUrl, IWebClient webClient)
            : base(baseUrl, webClient)
        {
        }

        /// <summary>
        /// Delete the Slot
        /// </summary>
        /// <param name="slotId"> Slot Id</param>
        public ApiResponseV2<ScheduleSlot> DeleteSlot(int slotId)
        {
            var result = Delete<ApiResponseV2<ScheduleSlot>>(string.Format("v2/schedule/consultation/slot/{0}", slotId), null);
            return result;
        }

        /// <summary>
        /// Delete the Slot
        /// </summary>
        /// <param name="slotId"> Slot Id</param>
        /// <param name="timeSpan">Time Span </param>
        public ApiResponseV2<ScheduleSlot> DeleteSlot(int slotId, object timeSpan)
        {
            var result = Delete<ApiResponseV2<ScheduleSlot>>(string.Format("v2/schedule/consultation/slot/{0}", slotId), timeSpan);
            return result;
        }
    }
}