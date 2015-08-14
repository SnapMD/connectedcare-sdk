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

using SnapMD.ConnectedCare.Sdk.Models;
using Newtonsoft.Json.Linq;

namespace SnapMD.ConnectedCare.Sdk
{
    public class TokenApi : ApiCall
    {
        public TokenApi(string baseUrl, int hospitalId, string developerId, string apiKey, Interfaces.IWebClient webClient)
            : base(baseUrl, webClient, developerId: developerId, apiKey: apiKey)
        {
            HospitalId = hospitalId;
        }

        public int HospitalId { get; private set; }

        public string GetToken(string email, string secret)
        {
            //done V2ing
            var request = new
            {
                email,
                password = secret,
                hospitalId = HospitalId,
                userTypeId = 1
            };
            
            var response = Post("v2/account/token", request);
            
            var dataEnumerator = response.ToObject<ApiResponseV2<SerializableToken>>();
            if (dataEnumerator.Data != null)
            {
                foreach (var entry in dataEnumerator.Data)
                {
                    return entry.access_token;
                }
            }

            return null;
        }
    }
}