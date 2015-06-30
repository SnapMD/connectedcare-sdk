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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

using Moq;
using NUnit.Framework;
using SnapMD.ConnectedCare.Sdk;
using SnapMD.ConnectedCare.Sdk.Interfaces;

using System.Net;

using FizzWare.NBuilder;


namespace SnapMD.ConnectedCare.Sdk.Test
{
    [TestFixture]
    class PaymentApiTests : TestBase
    {
        [Test]
        public void GetCustomer()
        {
            string url, token;
            var mockWebClient = TokenandWebClientSetup(out url, out token);
            mockWebClient.Setup(x => x.DownloadString(new Uri(@"http://snap.local/api/hospital/1/payments"))).Returns("{\"PaymentProfile\":[{\"CardNumber\":\"4111111111111111\", \"ExpiryMonth\":\"12\", \"ExpiryYear\":\"2015\" }]}");

            var target = new PaymentsApi(url, token, 1, Settings.Default.ApiDeveloperId, Settings.Default.ApiKey, mockWebClient.Object);
            var actual = target.GetCustomerProfile(15);

            Assert.False(target.NotFound);
            Assert.False(target.ServerError);
            Assert.NotNull(actual);
            //Assert.AreEqual(actual.PaymentProfiles[0].CardNumber.Value, "XXXX1111");
        }

        [Test]
        public void RegisterProfile()
        {
            var paymentData = new
            {
                CardNumber = "4111111111111111",
                ExpiryMonth = 12,
                ExpiryYear = DateTime.Today.Year
            };

            string url, token;
            var mockWebClient = TokenandWebClientSetup(out url, out token);
            mockWebClient.Setup(x => x.UploadString(new Uri(@"http://snap.local/api/patients/payments"), "POST", "{\"CardNumber\":\"4111111111111111\",\"ExpiryMonth\":12,\"ExpiryYear\":2015}")).Returns("{\"profileId\":\"2\"}");

            var target = new PaymentsApi(url, token, 1, Settings.Default.ApiDeveloperId, Settings.Default.ApiKey, mockWebClient.Object);
            var result = target.RegisterProfile(15, paymentData);

            Assert.Greater(result.Value<int>("profileId"), 1);
        }
    }
}
