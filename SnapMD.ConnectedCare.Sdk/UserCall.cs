﻿//    Copyright 2015 SnapMD, Inc.
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
using SnapMD.ConnectedCare.ApiModels;
using Newtonsoft.Json.Linq;


namespace SnapMD.ConnectedCare.Sdk
{
    public class UserCall : ApiCall
    {
        public UserCall(string baseUrl, string bearerToken, string developerId, string apiKey)
            : base(baseUrl, new SnapMD.ConnectedCare.Sdk.Wrappers.WebClientWrapper(new System.Net.WebClient()), bearerToken, developerId, apiKey)
        {
        }

        public int GetUserId()
        {
            //var baseUrl = new Uri(_baseUrl);
            //var url = new Uri(baseUrl, "account/user");
            var o = MakeCall("account/userv2");

            //userId = Convert.ToInt32(o["id"]);

            var dataEnumerator = ((JObject)o).ToObject<ApiResponseV2<SerializableUser>>().Data.GetEnumerator();

            while (dataEnumerator.MoveNext())
                if (dataEnumerator.Current.id > 0)
                    return dataEnumerator.Current.id;

            return 0;
        }
    }
}