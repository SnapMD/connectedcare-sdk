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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Moq;
using NUnit.Framework;

using SnapMD.ConnectedCare.Sdk;
using SnapMD.ConnectedCare.Sdk.Interfaces;

using System.Net;
using SnapMD.ConnectedCare.Sdk.Test.Properties;

namespace SnapMD.ConnectedCare.Sdk.Test
{
    [TestFixture]
    public class HospitalApiTests: TestBase
    {
        [Test]
        public void TestGetAddress()
        {
            string url, token;

            Mock<IWebClient> mockWebClient = TokenandWebClientSetup(out url, out token);
            mockWebClient.Setup(x => x.DownloadString(
                new Uri(Settings.Default.BaseUrl + @"/HospitalAddress/1")))
                .Returns("{\"data\":{\"addressText\":\"1000 wilshire blvd, los angeles, ca 90017\"}}");

            var api = new HospitalApi(url, null, Settings.Default.ApiDeveloperId, Settings.Default.ApiKey, mockWebClient.Object);
            Assert.AreEqual("1000 wilshire blvd, los angeles, ca 90017", api.GetHospitalAddressById(1));
        }

        [Test]
        public void TestGetAddressLoggedIn()
        {
            string url, token;

            Mock<IWebClient> mockWebClient = TokenandWebClientSetup(out url, out token);
            mockWebClient.Setup(x => x.DownloadString(new Uri(@"http://snap.local/api/hospitaladdress"))).Returns("{\"data\":\"1000 wilshire blvd, los angeles, ca 90017\"}");

            var api = new HospitalApi(url, token, Settings.Default.ApiDeveloperId, Settings.Default.ApiKey, mockWebClient.Object);
            var returnVal = api.GetAddress();
            Assert.AreEqual("1000 wilshire blvd, los angeles, ca 90017", returnVal);
        }

        [Test]
        public void TestGetHospital()
        {
            string url, token;

            Mock<IWebClient> mockWebClient = TokenandWebClientSetup(out url, out token);
            mockWebClient.Setup(x => x.DownloadString(new Uri(@"http://snap.local/api/hospital"))).Returns("{\"hospitalId\":1}");

            var api = new HospitalApi(url, token, Settings.Default.ApiDeveloperId, Settings.Default.ApiKey, mockWebClient.Object);
            var result = api.GetHospital();

            Assert.AreEqual(result.Value<int>("hospitalId"), 1);
        }
    }
}
