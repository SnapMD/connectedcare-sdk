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
using Newtonsoft.Json.Linq;

using SnapMD.ConnectedCare.Sdk.Interfaces;

namespace SnapMD.ConnectedCare.Sdk
{
    public class HospitalApi : ApiCall
    {
        public HospitalApi(string baseUrl, string bearerToken, string developerId, string apiKey, IWebClient client)
            : base(baseUrl, client, bearerToken, developerId, apiKey)
        {
        }

        public string GetAddress()
        {
            var o = MakeCall("hospitaladdress");
            return Convert.ToString(o["data"]);
        }
        
        public string GetHospitalAddressById(int hospitalId)
        {
            var o = MakeCall("HospitalAddress/" + hospitalId);
            var data = o["data"];
            return Convert.ToString(data["addressText"]);
        }

        public JObject GetHospital()
        {
            var o = MakeCall("hospital");
            return o;
        }
    }
}