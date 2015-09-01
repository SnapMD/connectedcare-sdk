//    Copyright 2015 SnapMD, Inc.
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
using System.Linq;
using Newtonsoft.Json.Linq;
using SnapMD.ConnectedCare.ApiModels;
using SnapMD.ConnectedCare.Sdk.Interfaces;
using SnapMD.ConnectedCare.Sdk.Models;

namespace SnapMD.ConnectedCare.Sdk
{
    public class HospitalApi : ApiCall
    {
        public HospitalApi(string baseUrl, string bearerToken, string developerId, string apiKey, IWebClient client)
            : base(baseUrl, client, bearerToken, developerId, apiKey)
        {
        }

        /// <summary>
        /// Gets the hospital address based on the current logged-in user's provider ID.
        /// </summary>
        /// <returns></returns>
        public ApiResponseV2<HospitalAddress> GetAddress()
        {
            var o = MakeCall<ApiResponseV2<HospitalAddress>>("v2/hospitaladdress");
            return o;
        }

        /// <summary>
        /// Gets the hospital address based on provider ID.
        /// </summary>
        /// <param name="hospitalId"></param>
        /// <returns></returns>
        public ApiResponseV2<HospitalAddress> GetAddress(int hospitalId)
        {
            var o = MakeCall<ApiResponseV2<HospitalAddress>>("v2/hospitaladdress/" + hospitalId);
            return o;
        }

        public ApiResponseV2<HospitalInfo> GetHospital()
        {
            var o = MakeCall<ApiResponseV2<HospitalInfo>>("v2/hospital");
            return o;
        }
    }
}