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
    public class EncounterAdminApiTests : TestBase
    {
        private const string httpPost = "POST";

        private EncounterAdminApi api;
        private Mock<IWebClient> mockWebClient;
        private string accessToken;

        private readonly ScheduleConsultationDetailByUsername encounterData = new ScheduleConsultationDetailByUsername
        {
            AssignedDoctorUsername = "abc@abc.com",
            PatientUsername = "qwe@qwe.com",
            IsNoCharge = true,
            ConsultationId = 13,
            PrevConsultationID = 12,
            PrimaryConsern = "headake",
            SecondaryConsern = "N/A",
            Note = "test note",
            ProfileImagePath = "http://path.com/profile.png",
            ScheduledTime = DateTime.Now.AddDays(2),
            DoctorName = "House",
            ScheduledFrom = "Test form",
            SchedulingReasonType = 1,
            Patient = new PatientShortInfo
            {
                Dob = DateTime.Now.AddYears(30),
                Gender = "M",
                Address = "5885 Cunard",
                City = "Halifax",
                Name = "John Doe",
                PrimaryPhysician = "House",
                ZipCode = "B3K1E3",
                Id = 1
            }
        };

        [TestFixtureSetUp]
        public void TestSetup()
        {
            mockWebClient = TokenandWebClientSetup(out accessToken);

            api = new EncounterAdminApi(
                Settings.Default.BaseUrl, accessToken,
                Settings.Default.ApiDeveloperId,
                Settings.Default.ApiKey,
                mockWebClient.Object);
        }

        [Test]
        public void TestScheduleConsultation()
        {
            var response = new ApiResponseV2<ScheduledConsultationResult>(new ScheduledConsultationResult
            {
                ConsultationId = 3
            });

            mockWebClient.Setup(c => c.UploadString(It.IsAny<Uri>(), "POST", It.IsAny<string>()))
                .Returns(JsonConvert.SerializeObject(response));

            var result = api.ScheduleEncounter(encounterData);

            Assert.AreEqual(response.Data.First().ConsultationId, result.ConsultationId);

            mockWebClient.Verify(client => client.UploadString(
                It.Is<Uri>(uri => uri.ToString().Contains("v2/admin/schedule/consultations")),
                httpPost,
                JsonConvert.SerializeObject(encounterData)));
        }
    }
}