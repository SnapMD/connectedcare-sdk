using System;
using System.Linq;
using FizzWare.NBuilder;
using Moq;
using Newtonsoft.Json;
using NUnit.Framework;
using SnapMD.VirtualCare.ApiModels;
using SnapMD.VirtualCare.ApiModels.Scheduling;
using SnapMD.VirtualCare.Sdk.Interfaces;
using SnapMD.VirtualCare.Sdk.Models;
using SnapMD.VirtualCare.Sdk.Tests.Properties;

namespace SnapMD.VirtualCare.Sdk.Tests
{
    //[TestFixture]
    //public class AppointmentsApiTests : TestBase
    //{
    //    private readonly ISingleObjectBuilder<AppointmentResponse> _appointmentBuilder = Builder<AppointmentResponse>.CreateNew();
    //    private AppointmentsApi _api;
    //    private AppointmentRequest _appointment;
    //    private Mock<IWebClient> _mockWebClient;
    //    private string _accessToken;

    //    [SetUp]
    //    public void Setup()
    //    {
    //        _mockWebClient = TokenandWebClientSetup(out _accessToken);

    //        _api = new AppointmentsApi(
    //            Settings.Default.BaseUrl, _accessToken,
    //            Settings.Default.ApiDeveloperId,
    //            Settings.Default.ApiKey,
    //            _mockWebClient.Object);

    //        _appointment = _appointmentBuilder.Build();
    //    }

    //    [Test]
    //    public void PostAppointmentTest()
    //    {
    //        var expectedResponse = new ApiResponseV2<AppointmentResponse>(_appointmentBuilder.Build());

    //        _mockWebClient.Setup(c => c.UploadString(It.IsAny<Uri>(), "POST", It.IsAny<string>()))
    //            .Returns(JsonConvert.SerializeObject(expectedResponse));

    //        var response = _api.CreateAppointment(_appointment);

    //        AssertAppointments(expectedResponse.Data.First(), response.Data.First());

    //        _mockWebClient.Verify(client => client.UploadString(
    //            It.Is<Uri>(uri => uri.ToString().EndsWith("v2.1/patients/appointments")),
    //            "POST",
    //            JsonConvert.SerializeObject(_appointment)));
    //    }

    //    [Test]
    //    public void AddParticipantsTest()
    //    {
    //        var expected = new ApiResponseV2<AppointmentParticipantResponse>(Builder<AppointmentParticipantResponse>.CreateNew()
    //            .With(c => c.Person = Builder<PersonRecord>.CreateNew().Build())
    //            .Build());

    //        _mockWebClient.Setup(c => c.UploadString(It.IsAny<Uri>(), "POST", It.IsAny<string>()))
    //            .Returns(JsonConvert.SerializeObject(expected));

    //        var request = Builder<AppointmentParticipantResponse>.CreateNew()
    //             .With(c => c.Person = Builder<PersonRecord>.CreateNew().Build())
    //             .Build();
    //        var appointmentId = Guid.NewGuid();
    //        var actual = _api.AddParticipant(appointmentId, request);
    //        Assert.AreEqual(request.Person.Name.Family, actual.Data.First().Person.Name.Family);
    //    }

    //    [Test]
    //    public void GetParticipantsTest()
    //    {
    //        var expected = new ApiResponseV2<AppointmentParticipantResponse>(Builder<AppointmentParticipantResponse>.CreateListOfSize(3)
    //            .All().With(c => c.Person = Builder<PersonRecord>.CreateNew().Build())
    //            .Build());

    //        _mockWebClient.Setup(c => c.DownloadString(It.IsAny<Uri>()))
    //            .Returns(JsonConvert.SerializeObject(expected));
            
    //        var appointmentId = Guid.NewGuid();
    //        var actual = _api.GetParticipants(appointmentId);
    //        Assert.AreEqual(actual.Data.First().Person.Name.Family, actual.Data.First().Person.Name.Family);
    //    }

    //    [Test]
    //    public void CancelAppointmentTest()
    //    {
    //        var appointmentId = Guid.NewGuid();
    //        _api.CancelAppointment(appointmentId);

    //        _mockWebClient.Verify(client => client.UploadString(
    //            It.Is<Uri>(uri => uri.ToString().EndsWith("v2.1/patients/appointments/" + appointmentId)),
    //            "DELETE", It.IsAny<string>()));
    //    }

    //    private static void AssertAppointments(AppointmentResponse expected, AppointmentResponse actual)
    //    {
    //        Assert.AreEqual(expected.AvailabilityBlockId, actual.AvailabilityBlockId);
    //        Assert.AreEqual(expected.AppointmentId, actual.AppointmentId);
    //        Assert.AreEqual(expected.AppointmentStatusCode, actual.AppointmentStatusCode);
    //        Assert.AreEqual(expected.AppointmentTypeCode, actual.AppointmentTypeCode);
    //        Assert.AreEqual(expected.StartTime, actual.StartTime);
    //        Assert.AreEqual(expected.EndTime, actual.EndTime);
    //        Assert.AreEqual(expected.OnDemandRequestId, actual.OnDemandRequestId);
    //    }
    //}
}
