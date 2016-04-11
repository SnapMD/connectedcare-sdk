using System;
using NUnit.Framework;
using SnapMD.VirtualCare.ApiModels;

namespace SnapMD.VirtualCare.Sdk.Tests.ModelTests
{
    [TestFixture]
    public class NewPatientRequestValidationTest
    {

        [Test]
        public void TestModelValidationFail()
        {
            var target = new NewPatientRequest();
            var thrown = Assert.Throws<Exception>(() => target.ValidateModel(m => new Exception(m)));
            Assert.AreEqual("Name is required.", thrown.Message);

            target.Name = new FirstLast();
            thrown = Assert.Throws<Exception>(() => target.ValidateModel(m => new Exception(m)));
            Assert.AreEqual("First name required.", thrown.Message);
            
            target.Name.First = "First Name";
            thrown = Assert.Throws<Exception>(() => target.ValidateModel(m => new Exception(m)));
            Assert.AreEqual("Email address required.", thrown.Message);

            target.Email = "test@mail.com";
            thrown = Assert.Throws<Exception>(() => target.ValidateModel(m => new Exception(m)));
            Assert.AreEqual("Address required.", thrown.Message);

            target.Address = "I.R. Address";
            thrown = Assert.Throws<Exception>(() => target.ValidateModel(m => new Exception(m)));
            Assert.AreEqual("Date of birth required.", thrown.Message);


            target.Dob = new DateTime(2015, 1, 1);
            thrown = Assert.Throws<Exception>(() => target.ValidateModel(m => new Exception(m)));
            Assert.AreEqual("ProviderId required.", thrown.Message);

            target.ProviderId = 1;
            bool actual = target.ValidateModel(m => new Exception(m));
            Assert.IsTrue(actual);
        }
    }
}
