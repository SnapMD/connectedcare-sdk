using NUnit.Framework;
using SnapMD.ConnectedCare.ApiModels;
using System;

namespace SnapMD.ConnectedCare.Sdk.Tests
{
    [TestFixture]
    class PatientProfileRequestTests
    {
        private PatientProfileRequest[] _requests;

        [SetUp]
        public void Setup()
        {
            _requests = new[]
            {
                new PatientProfileRequest
                {
                    PatientName = "John",
                    LastName = "Doe",
                    Dob = DateTime.Parse("01/01/1945"),
                    Gender = "M",
                    Height = "5|8",
                    Weight = "145"
                },
                new PatientProfileRequest
                {
                    PatientName = "John",
                    LastName = "",
                    Dob = DateTime.Parse("01/01/1945"),
                    Gender = "M",
                    Height = "5|8",
                    Weight = "145"
                },
                new PatientProfileRequest
                {
                    PatientName = "John",
                    LastName = "Doe",
                    Dob = DateTime.Parse("01/01/2045"),
                    Gender = "M",
                    Height = "5|8",
                    Weight = "145"
                },
            };
        }

        [Test]
        public void PatientProfileRequest_TestValidProfile()
        {
            Assert.IsTrue(string.IsNullOrEmpty(_requests[0].ValidateInputs()));
        }

        [Test]
        public void PatientProfileRequest_TestMissingLastName()
        {
            Assert.IsTrue("Please enter last name <br/>".Equals(_requests[1].ValidateInputs()));
        }

        [Test]
        public void PatientProfileRequest_TestFutureDob()
        {
            Assert.IsTrue("Date of Birth can't be in the future <br/>".Equals(_requests[2].ValidateInputs()));
        }
    }
}
