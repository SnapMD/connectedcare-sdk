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
using Moq;
using NUnit.Framework;
using SnapMD.ConnectedCare.Sdk.Interfaces;
using SnapMD.ConnectedCare.Sdk.Tests.Properties;

namespace SnapMD.ConnectedCare.Sdk.Tests
{
    [TestFixture]
    public class HospitalApiTests : TestBase
    {
        [Test]
        public void TestGetAddress()
        {
            string token;

            Mock<IWebClient> mockWebClient = TokenandWebClientSetup(out token);

            mockWebClient.Setup(x => x.DownloadString(
                new Uri(BaseUri, @"v2/hospitaladdress/1")))
                .Returns("{\"$id\": \"1\",\"data\": [{\"$id\": \"2\", \"hospitalId\": \"1\", \"address\": \"1000 wilshire blvd, los angeles, ca 90017\"}]}");
            
            //IWebClient webClient = TokenandWebClientSetupRemoteCall(out url, out token);

            var api = new HospitalApi(Settings.Default.BaseUrl, null, Settings.Default.ApiDeveloperId, Settings.Default.ApiKey, mockWebClient.Object);

            var response = api.GetAddress(1);
            Assert.IsNotNull(response);
            Assert.IsNotNull(response.Data);
            Assert.IsNotNull(response.Data.FirstOrDefault());
            var addressText = response.Data.First().address;
            Assert.AreEqual("1000 wilshire blvd, los angeles, ca 90017", addressText);
        }

        [Test]
        public void TestGetHospital()
        {
            string token;

            HospitalApi api = null;

            Mock<IWebClient> mockWebClient = TokenandWebClientSetup(out token);
            mockWebClient.Setup(x => x.DownloadString(
                new Uri(BaseUri, @"v2/hospital")))
                .Returns("{\"$id\": \"1\",\"data\": [{\"$id\": \"2\", \"hospitalId\": \"1\"}]}");
                

            api = new HospitalApi(Settings.Default.BaseUrl, token, Settings.Default.ApiDeveloperId, Settings.Default.ApiKey, mockWebClient.Object);

            var result = api.GetHospital();

            Assert.AreEqual(result.Data.First().HospitalId, 1);
        }
    }
}
