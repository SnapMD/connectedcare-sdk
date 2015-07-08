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
    [TestFixture, Explicit]
    public class TokenApiTests
    {
        [Test]
        public void TestLogin()
        {
            string tokenResult = "0ghV8LuA8Autl1lvt1iFNDiJPX775WcvXVQRHlAve4U1wI01GYYdj9y_Z1zo5h2L2UhYmhTLdAoFD6YUsN_OU2ZAuxYb1OBoJ6IudOBYhUGEaAWzDFYtujxGX8jHqY-RS38-fpY9yirodkVScKkqQcg-vNrTtAC3WqdFpJOKowUnkNR_251ZEsUSB9T55n7ljFSXG0v-u8YKhUrDbSz2p6sEPjA1Um-3_McITz_TARCCZJPqOCIN-wckA8Tsfp0ID-6lJOjCMpYF9u3ErBnEBTMaU6aC4BOXUPL-88nh3bToq0Wrm60bLrxXWlnJY_rZbjalgw_Jps8XYAJBaXYfMKoK75xIe1sYqAlUgBfMKsW42a146rqX--HsBJ94wNaWitZzU5TQ6TNFZLsC4NVQ8Q";
            
            Mock<IWebClient> mockWebClient = new Mock<IWebClient>();

            mockWebClient.Setup(x => x.UploadString(new Uri(Settings.Default.BaseUrl + @"/account/tokenv2"), "POST", "{\"email\":\"aaron.lord+toddg@snap.md\",\"hospitalId\":1,\"password\":\"Password@123\",\"userTypeId\":1}")).Returns("{ \"$id\": \"1\", \"data\": [ { \"$id\": \"2\", \"access_token\": \"jq8_ntQSXkBFl8HaDX8dshTOjgweE6gbMQ-TgPmhZJ039ejlSFEmopkjIQdbfW3ymE96fkG7Jw2VjpaEc71CBta7ZGaUSncwi7bEO1d2c5wkwAQJ1d0Obk90rNRFcLaCn9QU7pfQlyJcCdRtS2icYmKfUzJmwlsuN7q2qyqtKRgWzM0aEPRL5E4hExwub5wEPdAIfpseFX6jCdEZeMuu_PScHdqdds5cVZtqA8_CHeQOD0YrHWYK11CPTJ0HoL8rz0HvZ-csnwo-KXcB1g3DNxrcbEtn2lq2LNn-1OkzvpFZ1ZpH5G1CKkEIfBw5wQgrihcG0m69vGizCn_ww2AgvelqXiM-uZOqer7VeQyimudhn22zc2CHQoLnknQzeJcX118eCjhcnND6yWDjiQXnSg\" } ] }");
            mockWebClient.Setup(x => x.Headers).Returns(new WebHeaderCollection());

            string url = Settings.Default.BaseUrl+ @"/";

            var apiCall = new TokenApi(url, 1, Settings.Default.ApiDeveloperId, Settings.Default.ApiKey, mockWebClient.Object);

            Assert.IsNotNullOrEmpty(apiCall.GetToken("aaron.lord+toddg@snap.md", "Password@123"));
        }
    }
}
