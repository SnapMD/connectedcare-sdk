using System;
using NUnit.Framework;
using SnapMD.VirtualCare.ApiModels.Routing;

namespace SnapMD.VirtualCare.Sdk.Tests.ModelTests
{
    [TestFixture]
    public class GeoCoordinateTests
    {
        [Test]
        public void GeoCoordinate_Equal_Tests()
        {
            GeoCoordinate c1 = null, c2 = null;

            var c3 = new GeoCoordinate
            {
                Latitude = 1.1m,
                Longitude = -100m,
            };
            var c4 = new GeoCoordinate
            {
                Latitude = 1.1m,
                Longitude = -100m,
            };
            var c5 = new GeoCoordinate
            {
                Latitude = 1.1m
            };

            object o1 = "a string";
            object o2 = c5;

            Assert.AreEqual(true, c1 == c2);
            Assert.AreEqual(true, c3 == c4);
            Assert.AreEqual(true, c1 != c3);
            Assert.AreEqual(true, c4 != c2);
            Assert.AreEqual(true, c5 == null);
            Assert.AreEqual(true, null == c5);
            Assert.AreEqual(false, c5.Equals(o1));
            Assert.AreEqual(true, c5.Equals(o2));
        }

        [Test]
        public void GeoCoordinate_GetHashCode_Test()
        {
            var c3 = new GeoCoordinate
            {
                Latitude = 1.1m,
                Longitude = -100m,
            };
            var c4 = new GeoCoordinate
            {
                Latitude = 1.1m,
                Longitude = -100m,
            };
            Assert.AreEqual(true, c3.GetHashCode() == c4.GetHashCode());
        }

        [Test]
        public void GeoCoordinate_Distance_Tests()
        {
            var c1 = new GeoCoordinate
            {
                Latitude = 34.10m,
                Longitude = -180.01m,
            };
            var c2 = new GeoCoordinate
            {
                Latitude = 35.12m,
                Longitude = -179.11m,
            };
            var distKm = GeoCoordinate.Distance(c1, c2, RoutingDistanceUnit.Kilometer);
            var distNm = GeoCoordinate.Distance(c1, c2, RoutingDistanceUnit.NauticalMile);
            var distSm = GeoCoordinate.Distance(c1, c2, RoutingDistanceUnit.StatuteMile);

            Assert.AreEqual(140.16, Math.Round(distKm, 2));
            Assert.AreEqual(75.63, Math.Round(distNm, 2));
            Assert.AreEqual(87.09, Math.Round(distSm, 2));
        }
    }
}
