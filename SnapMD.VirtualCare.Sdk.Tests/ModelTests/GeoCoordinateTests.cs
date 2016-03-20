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
            Assert.AreEqual(true, c3.GetHashCode() == c4.GetHashCode());
        }
    }
}
