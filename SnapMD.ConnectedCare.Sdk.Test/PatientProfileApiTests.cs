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
using FizzWare.NBuilder.Implementation;
using NUnit.Framework;
using SnapMD.ConnectedCare.Sdk.Test.Properties;
using SnapMD.ConnectedCare.Sdk.Test.Properties;

namespace SnapMD.ConnectedCare.Sdk.Test
{
    [TestFixture]
    public class PatientProfileApiTests : TestBase
    {
        [Test]
        public void TestPatientProfileInsert()
        {
            string token;
            var mockWebClient = TokenandWebClientSetup(out token);
            string testEmail = "test" + Guid.NewGuid() + "@test.com";

            DateTime mockDate = DateTime.UtcNow;

            var mock = new
            {
                EmailAddress = testEmail,
                PatientProfileData = new { PatientName = "p", LastName = "l", Enthicity = 1, Gender = "m", DOB = mockDate, Height = 1, Weight = 1 },
                PatientUpdateRequest = new { Height = 2, Weight = 1 },
                PatientMedicalHistoryData = new { Height = 2, Weight = 1 }
            };

            mockWebClient.Setup(x => x.UploadString(new Uri(BaseUri, BaseUri.AbsolutePath + "/patients/profile"), "POST",
                Newtonsoft.Json.JsonConvert.SerializeObject(mock)))
                .Returns("{ \"$id\": \"1\",\"patientID\": \"1429\",\"securityToken\": \"\" }");

            var sdk = new PatientProfileApi(Settings.Default.BaseUrl, token, Settings.Default.ApiDeveloperId, Settings.Default.ApiKey,
                mockWebClient.Object);
            var result = sdk.AddPatient(mock);
            Assert.IsNotNull(result);
        }
    }
}
