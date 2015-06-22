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
using System.Text;
using System.IO;
using Moq;
using NUnit.Framework;
using SnapMD.ConnectedCare.Sdk;
using SnapMD.ConnectedCare.Sdk.Interfaces;

using System.Net;

namespace SnapMD.ConnectedCare.Sdk.Test
{
    [TestFixture]
    public class IntakeApiTests: TestBase
    {
        [Test]
        public void GetIntakes()
        {
            string intakeItemResult = "2323";

            string url, token;
            
            Mock<IWebClient> mockWebClient = TokenandWebClientSetup(out url, out token);
            mockWebClient.Setup(x => x.DownloadString(new Uri(@"http://snap.local/api/v2/codesets?hospitalId=1&fields=medicalconditions,medications,medicationallergies,consultprimaryconcerns,consultsecondaryconcerns"))).Returns("{\"data\":" + intakeItemResult + "}");
            
            var api = new SnapMD.ConnectedCare.Sdk.IntakeApi(url, token, Settings.Default.ApiDeveloperId, Settings.Default.ApiKey, mockWebClient.Object);
            var val = api.GetIntakeItems(1);

            Assert.NotNull(val);
            Assert.AreEqual(val.Last.Last.ToString(), intakeItemResult);
        }
    }
}