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
using SnapMD.ConnectedCare.Sdk.Tests.Properties;
using SnapMD.ConnectedCare.Sdk.Wrappers;

namespace SnapMD.ConnectedCare.Sdk.Tests
{
    public abstract class TestBase
    {
        public Uri BaseUri { get; set; }

        protected TestBase()
        {
            BaseUri = new Uri(Settings.Default.BaseUrl);
        }

        public Mock<IWebClient> TokenandWebClientSetup(out string token)
        {
            string tokenResult = "Sample_Token";

            Mock<IWebClient> mockWebClient = new Mock<IWebClient>();
            
            mockWebClient.Setup(x => x.UploadString(new Uri(BaseUri, @"v2/account/token"), "POST", 
                "{\"email\":\"aaron.lord+toddg@snap.md\",\"password\":\"Password@123\",\"hospitalId\":1,\"userTypeId\":1}"))
                .Returns("{\"$id\": \"1\",\"data\": [{\"$id\": \"2\",\"access_token\": \"" + tokenResult + "\"} ] }");

            mockWebClient.Setup(x => x.Headers).Returns(new WebHeaderCollection());

            var apiCall = new TokenApi(Settings.Default.BaseUrl, 1, Settings.Default.ApiDeveloperId, Settings.Default.ApiKey, mockWebClient.Object);
            //token = apiCall.GetToken("sameerfairgoogl@gmai.com", "P@ssword123");
            token = apiCall.GetToken("aaron.lord+toddg@snap.md", "Password@123");

            Assert.AreEqual(token, tokenResult);

            return mockWebClient;
        }

        public IWebClient TokenandWebClientSetupRemoteCall(out string token)
        {
            WebClientWrapper wclient = new WebClientWrapper(new MockWebClient());

            var apiCall = new TokenApi(Settings.Default.BaseUrl, 1, Settings.Default.ApiDeveloperId, Settings.Default.ApiKey, wclient);
            token = apiCall.GetToken("sameerfairgoogl@gmail.com", "P@ssword123");

            return wclient;
        }
    }
}