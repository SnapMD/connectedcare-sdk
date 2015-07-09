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
    public class TokenApiTests : TestBase
    {
        [Test]
        public void TestLogin()
        {
            Mock<IWebClient> mockWebClient = new Mock<IWebClient>();

            mockWebClient.Setup(x => x.UploadString(new Uri(BaseUri, @"/account/tokenv2"), "POST", "{\"email\":\"aaron.lord+toddg@snap.md\",\"password\":\"Password@123\",\"hospitalId\":1,\"userTypeId\":1}")).Returns("{ \"$id\": \"1\", \"data\": [ { \"$id\": \"2\", \"access_token\": \"jq8_ntQSXkBFl8HaDX8dshTOjgweE6gbMQ-TgPmhZJ039ejlSFEmopkjIQdbfW3ymE96fkG7Jw2VjpaEc71CBta7ZGaUSncwi7bEO1d2c5wkwAQJ1d0Obk90rNRFcLaCn9QU7pfQlyJcCdRtS2icYmKfUzJmwlsuN7q2qyqtKRgWzM0aEPRL5E4hExwub5wEPdAIfpseFX6jCdEZeMuu_PScHdqdds5cVZtqA8_CHeQOD0YrHWYK11CPTJ0HoL8rz0HvZ-csnwo-KXcB1g3DNxrcbEtn2lq2LNn-1OkzvpFZ1ZpH5G1CKkEIfBw5wQgrihcG0m69vGizCn_ww2AgvelqXiM-uZOqer7VeQyimudhn22zc2CHQoLnknQzeJcX118eCjhcnND6yWDjiQXnSg\" } ] }");
            mockWebClient.Setup(x => x.Headers).Returns(new WebHeaderCollection());

            string url = Settings.Default.BaseUrl;

            var apiCall = new TokenApi(url, 1, Settings.Default.ApiDeveloperId, Settings.Default.ApiKey, mockWebClient.Object);

            Assert.IsNotNullOrEmpty(apiCall.GetToken("aaron.lord+toddg@snap.md", "Password@123"));
        }
    }
}
