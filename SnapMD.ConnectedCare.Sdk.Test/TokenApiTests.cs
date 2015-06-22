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

            mockWebClient.Setup(x => x.UploadString(new Uri(@"http://snap.local/api/account/token"), "POST", "{\"email\":\"aaron.lord+toddg@snap.md\",\"hospitalId\":1,\"password\":\"Password@123\",\"userTypeId\":1}")).Returns("{\"access_token\":\"" + tokenResult + "\"}");
            mockWebClient.Setup(x => x.Headers).Returns(new WebHeaderCollection());

            string url = "http://snap.local/api/";

            var apiCall = new TokenApi(url, 1, Settings.Default.ApiDeveloperId, Settings.Default.ApiKey, mockWebClient.Object);

            Assert.IsNotNullOrEmpty(apiCall.GetToken("aaron.lord+toddg@snap.md", "Password@123"));
        }
    }
}
