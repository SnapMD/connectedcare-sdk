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
using SnapMD.ConnectedCare.Sdk.Models;
//using SnapMD.ConnectedCare.ApiModels;
using Newtonsoft.Json.Linq;

namespace SnapMD.ConnectedCare.Sdk
{
    public class UserApi : ApiCall
    {
        public UserApi(string baseUrl, string bearerToken, string developerId, string apiKey, SnapMD.ConnectedCare.Sdk.Interfaces.IWebClient client)
            : base(baseUrl, client, bearerToken, developerId, apiKey)
        {
        }

        public int? GetUserId()
        {
            var response = MakeCall("v2/account/user");


            var dataEnumerator = response.ToObject<ApiResponseV2<SerializableUser>>();
            if (dataEnumerator.Data != null)
            {
                foreach (var entry in dataEnumerator.Data)
                {
                    return entry.id;
                }
            }

            return null;
        }
    }
}