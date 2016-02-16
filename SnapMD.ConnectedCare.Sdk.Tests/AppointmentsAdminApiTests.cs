using System;
using System.Linq;
using FizzWare.NBuilder;
using Moq;
using Newtonsoft.Json;
using NUnit.Framework;
using SnapMD.ConnectedCare.ApiModels.Scheduling;
using SnapMD.ConnectedCare.Sdk.Interfaces;
using SnapMD.ConnectedCare.Sdk.Models;
using SnapMD.ConnectedCare.Sdk.Tests.Properties;

namespace SnapMD.ConnectedCare.Sdk.Tests
{
    [TestFixture]
    public class AppointmentsAdminApiTests : TestBase
    {
        private readonly ISingleObjectBuilder<AppointmentResponse> _appointmentBuilder = Builder<AppointmentResponse>.CreateNew();
        private AppointmentsAdminApi _api;
        private AppointmentResponse _appointment;
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

            _appointment = _appointmentBuilder.Build();
        }

        [Test]
        public void GetAppointmentTest()
        {
            var expectedResponse = new ApiResponseV2<AppointmentResponse>(_appointmentBuilder.Build());

            _mockWebClient.Setup(c => c.DownloadString(
                It.Is<Uri>(uri => uri.ToString().EndsWith("v2.1/clinicians/appointments/" + _appointment.AppointmentId))))
                .Returns(JsonConvert.SerializeObject(expectedResponse));

            var response = _api.GetAppointment(_appointment.AppointmentId);

            AssertAppointments(expectedResponse.Data.First(), response.Data.First());

            _mockWebClient.Verify(client => client.DownloadString(
                It.Is<Uri>(uri => uri.ToString().EndsWith("v2.1/clinicians/appointments/" + _appointment.AppointmentId))));
        }

        [Test]
        public void CreateAppointmentTest()
        {
            var expectedResponse = new ApiResponseV2<AppointmentResponse>(_appointmentBuilder.Build());

            _mockWebClient.Setup(c => c.UploadString(It.IsAny<Uri>(), "POST", It.IsAny<string>()))
                .Returns(JsonConvert.SerializeObject(expectedResponse));

            var response = _api.CreateAppointment(_appointment);

            AssertAppointments(expectedResponse.Data.First(), response.Data.First());

            _mockWebClient.Verify(client => client.UploadString(
                It.Is<Uri>(uri => uri.ToString().EndsWith("v2.1/clinicians/appointments")),
                "POST",
                JsonConvert.SerializeObject(_appointment)));
        }

        [Test]
        public void UpdateAppointmentTest()
        {
            var expectedResponse = new ApiResponseV2<AppointmentResponse>(_appointmentBuilder.Build());

            _mockWebClient.Setup(c => c.UploadString(It.IsAny<Uri>(), "PUT", It.IsAny<string>()))
                .Returns(JsonConvert.SerializeObject(expectedResponse));

            var response = _api.UpdateAppointment(expectedResponse.Data.First().AppointmentId, _appointment);

            AssertAppointments(expectedResponse.Data.First(), response.Data.First());

            _mockWebClient.Verify(client => client.UploadString(
                It.Is<Uri>(uri => uri.ToString().EndsWith("v2.1/clinicians/appointments")),
                "PUT",
                JsonConvert.SerializeObject(_appointment)));
        }

        [Test]
        public void DeleteAppointmentTest()
        {
            _api.DeleteAppointment(_appointment.AppointmentId);

            _mockWebClient.Verify(client => client.UploadString(
                It.Is<Uri>(uri => uri.ToString().EndsWith("v2.1/clinicians/appointments/" + _appointment.AppointmentId)),
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
            Assert.AreEqual(expected.OnDemandRequestId, actual.OnDemandRequestId);
        }
    }
}
