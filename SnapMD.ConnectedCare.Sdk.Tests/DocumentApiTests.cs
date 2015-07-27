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
using NUnit.Framework;
using SnapMD.ConnectedCare.ApiModels;
using SnapMD.ConnectedCare.Sdk.Tests.Properties;

namespace SnapMD.ConnectedCare.Sdk.Tests
{
    [TestFixture]
    public class DocumentApiTests : TestBase
    {
        [Test]
        public void TestGetDocument()
        {
            string token;

            var mockWebClient = TokenandWebClientSetup(out token);

            mockWebClient.Setup(x => x.DownloadString(
                new Uri(BaseUri, @"v2/publicdocuments?documentType=1&hospitalId=126")))
                .Returns(
                    "{\"$id\": \"1\",\"success\": true,\"data\": [{\"$id\": \"2\",\"documentType\": 1,\"hospitalId\": 126,\"documentText\": \"Lorem ipsum dolor sit amet\" }] }");

            var api = new DocumentsApi(Settings.Default.BaseUrl,
                Settings.Default.ApiDeveloperId,
                Settings.Default.ApiKey,
                mockWebClient.Object);
            var actual = api.GetDocument(DocumentTypeCode.TermsAndConditions, 126);
            Assert.IsNotNull(actual);
            Assert.AreEqual(1, actual.Data.Count());
            Assert.AreEqual("Lorem ipsum dolor sit amet", actual.Data.First().DocumentText);
        }
    }
}
