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

namespace SnapMD.ConnectedCare.Sdk
{
    public class HospitalCall : ApiCall
    {
        private readonly Uri _baseUri;

        public HospitalCall(string baseUrl, string bearerToken, string developerId, string apiKey)
            : base(baseUrl, new Wrappers.WebClientWrapper(new System.Net.WebClient()), bearerToken, developerId, apiKey)
        {
            _baseUri = new Uri(baseUrl);
        }

        public string GetHospitalAddress()
        {
            var o = MakeCall("hospital/address");
            return Convert.ToString(o["data"]);
        }
    }
}