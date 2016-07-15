using System;
using System.Linq;
using FizzWare.NBuilder;
using Moq;
using Newtonsoft.Json;
using NUnit.Framework;
using SnapMD.VirtualCare.ApiModels;
using SnapMD.VirtualCare.ApiModels.Scheduling;
using SnapMD.VirtualCare.Sdk.Interfaces;
using SnapMD.VirtualCare.Sdk.Tests.Properties;

namespace SnapMD.VirtualCare.Sdk.Tests
{
    [TestFixture]
    public class AppointmentsAdminApiTests : TestBase
    {
        private AppointmentsAdminApi _api;
        private Mock<IWebClient> _mockWebClient;
        private string _accessToken;

        [SetUp]
        public void Setup()
        {
            _mockWebClient = TokenandWebClientSetup(out _accessToken);

            _api = new AppointmentsAdminApi(
                Settings.Default.BaseUrl, _accessToken,
                Settings.Default.ApiDeveloperId,
                Settings.Default.ApiKey,
                _mockWebClient.Object);
        }

        [Test]
        public void GetAppointmentTest()
        {
            var appointment = Builder<AppointmentResponse>.CreateNew().Build();
            var expectedResponse = new ApiResponseV2<AppointmentResponse>(appointment);

            _mockWebClient.Setup(c => c.DownloadString(
                It.Is<Uri>(uri => uri.ToString().EndsWith("v2.1/clinicians/appointments/" + appointment.AppointmentId))))
                .Returns(JsonConvert.SerializeObject(expectedResponse));

            var response = _api.GetAppointment(appointment.AppointmentId);

            AssertAppointments(expectedResponse.Data.First(), response.Data.First());

            _mockWebClient.Verify(client => client.DownloadString(
                It.Is<Uri>(uri => uri.ToString().EndsWith("v2.1/clinicians/appointments/" + appointment.AppointmentId))));
        }

        [Test]
        public void CreateAppointmentTest()
        {
            var appointment = Builder<AppointmentResponse>.CreateNew().Build();
            var expectedResponse = new ApiResponseV2<AppointmentResponse>(appointment);

            _mockWebClient.Setup(c => c.UploadString(It.IsAny<Uri>(), "POST", It.IsAny<string>()))
                .Returns(JsonConvert.SerializeObject(expectedResponse));

            var response = _api.CreateAppointment(appointment);

            AssertAppointments(expectedResponse.Data.First(), response.Data.First());

            _mockWebClient.Verify(client => client.UploadString(
                It.Is<Uri>(uri => uri.ToString().EndsWith("v2.1/clinicians/appointments")),
                "POST",
                JsonConvert.SerializeObject(appointment)));
        }

        [Test]
        public void UpdateAppointmentTest()
        {
            var response = Builder<AppointmentResponse>.CreateNew().Build();
            var appointment = Builder<EditAppointmentRequest>.CreateNew().Build();
            var request = Builder<EditAppointmentRequest>.CreateNew().Build();
            var expectedResponse = new ApiResponseV2<AppointmentResponse>(response);

            _mockWebClient.Setup(c => c.UploadString(It.IsAny<Uri>(), "PUT", It.IsAny<string>()))
                .Returns(JsonConvert.SerializeObject(expectedResponse));

            var appointmentId = expectedResponse.Data.First().AppointmentId;
            appointment.AppointmentId = appointmentId;
            var actual = _api.UpdateAppointment(request);

            AssertAppointments(expectedResponse.Data.First(), actual.Data.First());

            _mockWebClient.Verify(client => client.UploadString(
                It.Is<Uri>(uri => uri.ToString().EndsWith("v2.1/clinicians/appointments/" + appointmentId)),
                "PUT",
                JsonConvert.SerializeObject(appointment)));
        }

        [Test]
        public void DeleteAppointmentTest()
        {
            var appointment = Builder<AppointmentResponse>.CreateNew().Build();
            _api.DeleteAppointment(appointment.AppointmentId);

            _mockWebClient.Verify(client => client.UploadString(
                It.Is<Uri>(uri => uri.ToString().EndsWith("v2.1/clinicians/appointments/" + appointment.AppointmentId)),
                "DELETE", It.IsAny<string>()));
        }

        private static void AssertAppointments(AppointmentResponse expected, AppointmentResponse actual)
        {
            Assert.AreEqual(expected.AvailabilityBlockId, actual.AvailabilityBlockId);
            Assert.AreEqual(expected.AppointmentId, actual.AppointmentId);
            Assert.AreEqual(expected.AppointmentStatusCode, actual.AppointmentStatusCode);
            Assert.AreEqual(expected.AppointmentTypeCode, actual.AppointmentTypeCode);
            Assert.AreEqual(expected.StartTime, actual.StartTime);
            Assert.AreEqual(expected.EndTime, actual.EndTime);
            Assert.AreEqual(expected.ConsultationRequestId, actual.ConsultationRequestId);
        }
    }
}
