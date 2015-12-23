using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SnapMD.ConnectedCare.ApiModels;

namespace SnapMD.ConnectedCare.Sdk.Tests.ModelTests
{
    [TestFixture]
    public class PatientOnBoardShortDetailValidationTests
    {
        [Test]
        public void TestModelValidationFail()
        {
            var target = new PatientOnBoardShortDetail();
            var thrown = Assert.Throws<Exception>(() => target.ValidateModel(m => new Exception(m)));
            Assert.AreEqual("First name required.", thrown.Message);

            target.FirstName = "First Name";
            thrown = Assert.Throws<Exception>(() => target.ValidateModel(m => new Exception(m)));
            Assert.AreEqual("Email address required.", thrown.Message);

            target.Email = "test@mail.com";
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
    }
}
