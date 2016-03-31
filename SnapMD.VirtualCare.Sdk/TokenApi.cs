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

using System.Linq;
using SnapMD.VirtualCare.Sdk.Models;
using Newtonsoft.Json.Linq;
using SnapMD.VirtualCare.ApiModels.Enums;
using SnapMD.VirtualCare.Sdk.Interfaces;

namespace SnapMD.VirtualCare.Sdk
{
    public class TokenApi : ApiCall, ITokenApi
    {
        public TokenApi(string baseUrl, int? hospitalId, string developerId, string apiKey, Interfaces.IWebClient webClient)
            : base(baseUrl, webClient, developerId: developerId, apiKey: apiKey)
        {
            HospitalId = hospitalId;
        }

        public int? HospitalId { get; private set; }

        public string GetToken(string email, string secret, UserType userType = UserType.Customer)
        {
            //done V2ing
            var request = new
            {
                email,
                password = secret,
                hospitalId = HospitalId,
                userTypeId = (int) userType
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

        public string GetToken(string jwt)
        {
            var response = MakeCall<ApiResponseV2<SerializableToken>>("v2/account/token?jwt=" + jwt);

            if (response.Data != null)
            {
                return response.Data.Select(entry => entry.access_token).FirstOrDefault();
            }

            return null;
        }

        /// <summary>
        /// Gets a token based on the token & agent from the Ping Identity sso service
        /// </summary>
        /// <param name="ssoToken">SSO token</param>
        /// <param name="agentId">Agent ID</param>
        /// <returns>Token, null or the bad request</returns>
        public string GetTokenForSso(string ssoToken, string agentId)
        {
            var response = MakeCall<ApiResponseV2<SerializableToken>>(
                $"v2/account/token?ssoToken={ssoToken}&agentId={agentId}");

            return response.Data?.Select(entry => entry.access_token).FirstOrDefault();
        }
    }
}