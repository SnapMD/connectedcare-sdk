//    Copyright 2016 SnapMD, Inc.
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
    public class PatientAdminApiTests : TestBase
    {
        private const string httpPost = "POST";
        private const string httpDelete = "DELETE";
        private const string patientEmail = "johndoe@gmail.com";
        private const int patientId = 1;

        private PatientAdminApi api;
        private Mock<IWebClient> mockWebClient;
        private string accessToken;

        private readonly PatientOnBoardShortDetail patientDetail = new PatientOnBoardShortDetail
        {
            Dob = DateTime.Now.AddYears(-30),
            Gender = "M",
            Address = "5885 Cunard st. Halifax",
            Email = patientEmail,
            CountryId = 1,
            TimeZoneId = 1,
            LastName = "Doe",
            FirstName = "John",
            MobileNumberWithCountryCode = "+19024405177"
        };

        [TestFixtureSetUp]
        public void TestSetup()
        {
            mockWebClient = TokenandWebClientSetup(out accessToken);

            api = new PatientAdminApi(
                Settings.Default.BaseUrl, accessToken,
                Settings.Default.ApiDeveloperId,
                Settings.Default.ApiKey,
                mockWebClient.Object);
        }

        [Test]
        public void TestAddPatient()
        {
            api.AddPatient(patientDetail);

            mockWebClient.Verify(webClient => webClient.UploadString(
                It.Is<Uri>(uri => uri.ToString().EndsWith("v2/admin/patients")),
                httpPost,
                JsonConvert.SerializeObject(patientDetail)));
        }

        [Test]
        public void TestDeletePatient()
        {
            mockWebClient.Setup(webClient => webClient.UploadString(
                It.IsAny<Uri>(),
                It.IsAny<string>(),
                It.IsAny<string>()))
                .Returns((string)null);

            api.DeletePatient(patientId);

            mockWebClient.Verify(webClient => webClient.UploadString(
                It.Is<Uri>(uri => uri.ToString().Contains(string.Format("v2/admin/patients/{0}", patientId))),
                httpDelete,
                It.IsAny<string>()));
        }

        [Test]
        public void TestGetPatient()
        {
            mockWebClient.Setup(client => client.DownloadString(
                It.Is<Uri>(uri => uri.ToString().Contains("v2/admin/patients?email=" + patientEmail))))
                .Returns(JsonConvert.SerializeObject(new ApiResponse<PatientOnBoardShortDetail>
                {
                    Data = patientDetail,
                    Success = true
                }));

            var response = api.GetPatient(patientEmail);

            Assert.IsNotNull(response);
            Assert.IsNotNull(response.Data);
            Assert.IsTrue(response.Success);
            Assert.AreEqual(patientDetail.Dob, response.Data.Dob);
            Assert.AreEqual(patientDetail.Email, response.Data.Email);
            Assert.AreEqual(patientDetail.Gender, response.Data.Gender);
            Assert.AreEqual(patientDetail.LastName, response.Data.LastName);
            Assert.AreEqual(patientDetail.FirstName, response.Data.FirstName);
            Assert.AreEqual(patientDetail.Address, response.Data.Address);
            Assert.AreEqual(patientDetail.CountryId, response.Data.CountryId);
            Assert.AreEqual(patientDetail.TimeZoneId, response.Data.TimeZoneId);
            Assert.AreEqual(patientDetail.MobileNumberWithCountryCode, response.Data.MobileNumberWithCountryCode);
        }
    }
}