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
using Newtonsoft.Json;
using NUnit.Framework;
using SnapMD.ConnectedCare.ApiModels;
using SnapMD.ConnectedCare.Sdk.Interfaces;
using SnapMD.ConnectedCare.Sdk.Models;
using SnapMD.ConnectedCare.Sdk.Tests.Properties;

namespace SnapMD.ConnectedCare.Sdk.Tests
{
    [TestFixture]
    public class EncounterApiTests : TestBase
    {
        private const string httpGet = "GET";

        private EncountersApi api;
        private Mock<IWebClient> mockWebClient;
        private string accessToken;

        private readonly ScheduledConsultation consultationResult = new ScheduledConsultation
        {
            ConsultationId = 1,
            ScheduledTime = DateTimeOffset.Now,
            AssignedDoctorFirstName = "Greg",
            AssignedDoctorLastName = "House",
            AssignedDoctorName = "Greg House",
            ConsultantUserId = 2,
            ConsultationAmount = 200,
            ConsultationStatus = 3,
            CopayAmount = 300,
            ExpiryTime = 4000,
            PatientFirstName = "John",
            PatientLastName = "Doe",
            PatientId = 4,
            PatientName = "John Doe",
            PatientUserId = 5,
            ScheduledId = 6,
            UserTimeZone = TimeZoneInfo.Utc
        };

        [TestFixtureSetUp]
        public void TestSetup()
        {
            mockWebClient = TokenandWebClientSetup(out accessToken);

            api = new EncountersApi(
                Settings.Default.BaseUrl, accessToken,
                Settings.Default.ApiDeveloperId,
                Settings.Default.ApiKey,
                mockWebClient.Object);
        }

        [Test]
        public void TestGetScheduledConsultations()
        {
            mockWebClient.Setup(client => client.DownloadString(
                It.Is<Uri>(uri => uri.ToString().Contains("v2/patients/scheduledconsultations"))))
                .Returns(JsonConvert.SerializeObject(new ApiResponseV2<ScheduledConsultation>(consultationResult)));

            var response = api.GetScheduledConsultations();

            Assert.IsNotNull(response);
            Assert.IsNotNull(response.Data);
            Assert.AreEqual(1, response.Data.Count());

            var actual = response.Data.First();

            Assert.AreEqual(consultationResult.AssignedDoctorFirstName, actual.AssignedDoctorFirstName);
            Assert.AreEqual(consultationResult.AssignedDoctorLastName, actual.AssignedDoctorLastName);
            Assert.AreEqual(consultationResult.AssignedDoctorName, actual.AssignedDoctorName);
            Assert.AreEqual(consultationResult.ConsultantUserId, actual.ConsultantUserId);
            Assert.AreEqual(consultationResult.ConsultationAmount, actual.ConsultationAmount);
            Assert.AreEqual(consultationResult.ConsultationId, actual.ConsultationId);
            Assert.AreEqual(consultationResult.ConsultationStatus, actual.ConsultationStatus);
            Assert.AreEqual(consultationResult.CopayAmount, actual.CopayAmount);
            Assert.AreEqual(consultationResult.ExpiryTime, actual.ExpiryTime);
            Assert.AreEqual(consultationResult.PatientFirstName, actual.PatientFirstName);
            Assert.AreEqual(consultationResult.PatientLastName, actual.PatientLastName);
            Assert.AreEqual(consultationResult.PatientName, actual.PatientName);
            Assert.AreEqual(consultationResult.PatientId, actual.PatientId);
            Assert.AreEqual(consultationResult.PatientUserId, actual.PatientUserId);
            Assert.AreEqual(consultationResult.UserTimeZone, actual.UserTimeZone);
            Assert.AreEqual(consultationResult.ScheduledId, actual.ScheduledId);
            Assert.AreEqual(consultationResult.ScheduledTime, actual.ScheduledTime);
        }
    }
}