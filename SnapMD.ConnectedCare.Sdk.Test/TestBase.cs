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
using System.Net;
using Moq;
using Newtonsoft.Json;
using NUnit.Framework;
using SnapMD.ConnectedCare.Sdk.Interfaces;
using SnapMD.ConnectedCare.Sdk.Test.Properties;

namespace SnapMD.ConnectedCare.Sdk.Test
{
    public abstract class TestBase
    {
        public Mock<IWebClient> TokenandWebClientSetup(out string url, out string token)
        {
            string tokenResult = "Sample_Token";

            Mock<IWebClient> mockWebClient = new Mock<IWebClient>();

            var request = JsonConvert.SerializeObject(new
            {
                email = Settings.Default.TestUsername,
                password = Settings.Default.TestPassword,
                hospitalId = 1,
                userTypeId = 1
            });
            mockWebClient.Setup(x => x.UploadString(new Uri(Settings.Default.BaseUrl + @"/account/token"), "POST", request);
            mockWebClient.Setup(x => x.Headers).Returns(new WebHeaderCollection());

            url = Settings.Default.BaseUrl;

            var apiCall = new TokenApi(url, 1, Settings.Default.ApiDeveloperId, Settings.Default.ApiKey,
                mockWebClient.Object);

            token = apiCall.GetToken(Settings.Default.TestUsername, Settings.Default.TestPassword);

            Assert.AreEqual(token, tokenResult);

            return mockWebClient;
        }
    }
}