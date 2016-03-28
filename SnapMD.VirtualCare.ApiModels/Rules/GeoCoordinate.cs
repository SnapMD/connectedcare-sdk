using System;

namespace SnapMD.VirtualCare.ApiModels.Rules
{
    /// <summary>
    /// GeoCoordinate
    /// </summary>
    public class GeoCoordinate
    {
        /// <summary>
        /// Gets or sets the latitude.
        /// </summary>
        /// <value>
        /// The latitude.
        /// </value>
        public decimal? Latitude { get; set; }

        /// <summary>
        /// Gets or sets the longitude.
        /// </summary>
        /// <value>
        /// The longitude.
        /// </value>
        public decimal? Longitude { get; set; }

        /// <summary>
        /// Determines whether the specified <see cref="System.Object" />, is equal to this instance.
        /// </summary>
        /// <param name="obj">The <see cref="System.Object" /> to compare with this instance.</param>
        /// <returns>
        ///   <c>true</c> if the specified <see cref="System.Object" /> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return Latitude == null || Longitude == null;
            }

            var c = obj as GeoCoordinate;
            if ((object)c == null)
            {
                return false;
            }

            return Latitude.Equals(c.Latitude) && Longitude.Equals(c.Longitude);
        }

        /// <summary>
        /// Equalses the specified c.
        /// </summary>
        /// <param name="c">The c.</param>
        /// <returns></returns>
        public bool Equals(GeoCoordinate c)
        {
            return Equals((object)c);
        }

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>
        /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. 
        /// </returns>
        public override int GetHashCode()
        {
            return Latitude.GetHashCode() ^ Longitude.GetHashCode();
        }

        /// <summary>
        /// Implements the operator ==.
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="b">The b.</param>
        /// <returns>
        /// The result of the operator.
        /// </returns>
        public static bool operator ==(GeoCoordinate a, GeoCoordinate b)
        {
            if (ReferenceEquals(a, b))
            {
                return true;
            }

            return (object)a != null ? a.Equals(b) : b.Equals(a);
        }

        /// <summary>
        /// Implements the operator !=.
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="b">The b.</param>
        /// <returns>
        /// The result of the operator.
        /// </returns>
        public static bool operator !=(GeoCoordinate a, GeoCoordinate b)
        {
            return !(a == b);
        }


        /// <summary>
        /// Distance between 2 geo locations.
        /// </summary>
        /// <param name="first">The first location.</param>
        /// <param name="second">The second location.</param>
        /// <param name="unit">The desired unit.</param>
        /// <returns></returns>
        public static decimal Distance(GeoCoordinate first, GeoCoordinate second, GeoDistanceUnit unit)
        {
            const double rad = Math.PI / 180.0;
            var latFirst = Convert.ToDouble(first.Latitude ?? 0) * rad;
            var latSecond = Convert.ToDouble(second.Latitude ?? 0) * rad;
            var deltaLong = Convert.ToDouble((first.Longitude ?? 0) - (second.Longitude ?? 0)) * rad;

            var dist = Math.Sin(latFirst) * Math.Sin(latSecond)
                + Math.Cos(latFirst) * Math.Cos(latSecond) * Math.Cos(deltaLong);
            dist = Math.Acos(dist) / rad;
            dist = UnitConvert(dist * 60 * 1.1515, unit);

            return Convert.ToDecimal(dist);
        }

        private static double UnitConvert(double dist, GeoDistanceUnit unit)
        {
            if (unit == GeoDistanceUnit.Kilometer)
            {
                dist = dist * 1.609344;
            }
            else if (unit == GeoDistanceUnit.NauticalMile)
            {
                dist = dist * 0.8684;
            }
            return dist;
        }
    }
}
