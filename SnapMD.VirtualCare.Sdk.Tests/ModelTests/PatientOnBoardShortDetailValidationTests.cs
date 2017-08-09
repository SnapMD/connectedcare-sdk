using System;
using NUnit.Framework;
using SnapMD.VirtualCare.ApiModels;

namespace SnapMD.VirtualCare.Sdk.Tests.ModelTests
{
    [TestFixture]
    public class PatientOnBoardShortDetailValidationTests
    {
        [Test]
        public void TestModelValidationFail()
        {
            var target = new PatientOnBoardShortDetailRequest();
            var thrown = Assert.Throws<Exception>(() => target.ValidateModel(m => new Exception(m)));
            Assert.AreEqual("First name required.", thrown.Message);

            target.FirstName = "First Name";
            thrown = Assert.Throws<Exception>(() => target.ValidateModel(m => new Exception(m)));
            Assert.AreEqual("Email address required.", thrown.Message);

            target.Email = "test@mail.com";
            thrown = Assert.Throws<Exception>(() => target.ValidateModel(m => new Exception(m)));
            Assert.AreEqual("Unknown gender. Expected gender any [M, F]", thrown.Message);

            target.Gender = "F";
            thrown = Assert.Throws<Exception>(() => target.ValidateModel(m => new Exception(m)));
            Assert.AreEqual("Date of birth required.", thrown.Message);

            target.Dob = new DateTime(2015, 1, 1);
            thrown = Assert.Throws<Exception>(() => target.ValidateModel(m => new Exception(m)));
            Assert.AreEqual("Address required.", thrown.Message);

            target.Address = "I.R. Address";
            thrown = Assert.Throws<Exception>(() => target.ValidateModel(m => new Exception(m)));
            Assert.AreEqual("Mobile number required.", thrown.Message);

            target.MobileNumberWithCountryCode = "12345678900";
            bool actual = target.ValidateModel(m => new Exception(m));
            Assert.IsTrue(actual);
        }

        [Test]
        public void TestModelValidationAllowsNullEmail()
        {
            var target = new PatientOnBoardShortDetailRequest
            {
                FirstName = "First Name",
                Email = null,
                Dob = new DateTime(2015, 1, 1),
                Address = "I.R. Address",
                MobileNumberWithCountryCode = "12345678900",
                Gender = "F"
            };
            bool actual = target.ValidateModel(m => new Exception(m), true);
            Assert.IsTrue(actual);
        }
    }
}
