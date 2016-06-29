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
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using FizzWare.NBuilder.Implementation;
using Newtonsoft.Json;
using NUnit.Framework;
using SnapMD.VirtualCare.ApiModels;
using SnapMD.VirtualCare.ApiModels.Enums;
using SnapMD.VirtualCare.Sdk.Models;
using SnapMD.VirtualCare.Sdk.Tests.Properties;
using SnapMD.VirtualCare.Sdk.Wrappers;

namespace SnapMD.VirtualCare.Sdk.Tests
{
    [TestFixture]
    public class PatientProfileApiTests : TestBase
    {
        [Test]
        public void TestAddDependentProfile()
        {
            string token;
            var mockWebClient = TokenandWebClientSetup(out token);
            string testEmail = "test" + Guid.NewGuid() + "@example.com";

            DateTime mockDate = DateTime.UtcNow;

            var mock = new AddPatientProfileRequest
            {
                EmailAddress = testEmail,
                PatientProfileData = new PatientUpdateRequest { PatientName = "p", LastName = "l", Ethnicity = 1, Gender = "m", Dob = mockDate, Height = "2", Weight = "1" },
                PatientMedicalHistoryData = new LegacyMedicalHistoryForm()
            };

            mockWebClient.Setup(x => x.UploadString(new Uri(BaseUri, "v2/familygroups/dependents"), "POST",
                JsonConvert.SerializeObject(mock)))
                .Returns("{\"$id\": \"1\",\"data\": [{\"$id\": \"2\", \"patientId\": \"1429\", \"securityToken\":\"\"}]}");

            var sdk = new PatientProfileApi(Settings.Default.BaseUrl, token, Settings.Default.ApiDeveloperId, Settings.Default.ApiKey,
                mockWebClient.Object);
            var result = sdk.AddDependent(mock);
            Assert.IsNotNull(result);
            Assert.IsNotNull(result.Data);
            Assert.IsNotNull(result.Data.FirstOrDefault());
            Assert.IsTrue(result.Data.First().PatientId > 0);
        }

        [Test]
        public void TestNewPatient()
        {
            string token;
            var mockWebClient = TokenandWebClientSetup(out token);
            const string mockRequest = "{\"Address\":\"my address\",\"Dob\":\"2015-12-01T00:00:00\",\"TimeZoneId\":1,\"Email\":\"mock@mail.com\",\"Name\":{\"First\":\"test\",\"Last\":\"user\"},\"Password\":\"password\",\"ProviderId\":1}";

            const string testResponse = @"{
                'data': [{
                'providerId':1,
                'patientId':129,
                'name': {'first':'test', 'last':'user'},
                'email' : 'mock@mail.com',
                'address' : 'my address',
                'dob' : '2015-12-01T00:00:00',
                'timeZoneId' : 1,
                'userLoginId':16577
                }]
            }";

            mockWebClient.Setup(x => x.UploadString(new Uri(BaseUri, "v2/patients"), "POST", mockRequest))
                .Returns(testResponse);

            var api = new PatientProfileApi(Settings.Default.BaseUrl, token, Settings.Default.ApiDeveloperId, Settings.Default.ApiKey,
                mockWebClient.Object);
            var result = api.NewPatient(new NewPatientRequest
            {
                ProviderId = 1,
                Name = new FirstLast { First = "test", Last = "user" },
                Email = "mock@mail.com",
                Address = "my address",
                Dob = new DateTime(2015,12,1),
                TimeZoneId = 1,
                Password = "password"
            });
            Assert.IsNotNull(result);
            Assert.IsNotNull(result.Data);
            Assert.IsNotNull(result.Data.FirstOrDefault());
            Assert.AreEqual(result.Data.First().PatientId, 129);
        }

        [Test]
        public void TestResendOnboardingEmail()
        {
            var request = new EmailUserRequest
            {
                HospitalId = 126,
                Email = "john.doe@example.com"
            };
            var expectedResponse = new ApiResponseV2<string>(request.Email);

            string token;
            var mockWebClient = TokenandWebClientSetup(out token);

            mockWebClient.Setup(x => x.UploadString(new Uri(BaseUri, "v2/patients/single-trip-registration/resend-onboarding-email"), "POST", JsonConvert.SerializeObject(request)))
                .Returns(JsonConvert.SerializeObject(expectedResponse));

            var api = new PatientProfileApi(Settings.Default.BaseUrl, null, Settings.Default.ApiDeveloperId, Settings.Default.ApiKey,
                mockWebClient.Object);

            var response = api.ResendOnboardingEmail(request);

            Assert.NotNull(response);
            Assert.AreEqual(request.Email, response.Data.First());
        }
    }
}
