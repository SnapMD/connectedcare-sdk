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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Moq;
using NUnit.Framework;

using SnapMD.ConnectedCare.Sdk;
using SnapMD.ConnectedCare.Sdk.Interfaces;

using FizzWare.NBuilder;
using SnapMD.ConnectedCare.Sdk.Models;

using System.Net;
using SnapMD.ConnectedCare.Sdk.Test.Properties;

namespace SnapMD.ConnectedCare.Sdk.Test
{
    [TestFixture]
    public class PatientProfileApiTests : TestBase
    {
        [Test]
        public void TestPatientProfileInsert()
        {
            string url, token;
            var mockWebClient = TokenandWebClientSetup(out url, out token);
            mockWebClient.Setup(x => x.UploadString(new Uri(@"http://snap.local/api/patients/profile"), "POST", "{\"EmailAddress\":\"test@test.com\",\"PatientUpdateRequest\":{\"Height\":2,\"Weight\":1},\"PatientMedicalHistory\":{\"Height\":2,\"Weight\":1}}")).Returns("{\"EmailAddress\":\"test@test.com\",\"PatientUpdateRequest\":{\"Height\":2,\"Weight\":1},\"PatientMedicalHistory\":{\"Height\":2,\"Weight\":1}}");

            var mock = new
            {
                EmailAddress = "test@test.com",
                PatientUpdateRequest = new { Height = 2, Weight = 1 },
                PatientMedicalHistory = new { Height = 2, Weight = 1 }
            };

            var sdk = new PatientProfileApi(url, token, Settings.Default.ApiDeveloperId, Settings.Default.ApiKey, mockWebClient.Object);
            var result = sdk.AddPatient(mock);
            Assert.IsNotNull(result[0]);
        }
    }
}
