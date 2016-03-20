using System;

namespace SnapMD.VirtualCare.ApiModels.Routing
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
        public static decimal Distance(GeoCoordinate first, GeoCoordinate second, RoutingDistanceUnit unit)
        {
            var latFirst = (double)(first.Latitude ?? 0);
            var lonFirst = (double)(first.Longitude ?? 0);
            var latSecond = (double)(second.Latitude ?? 0);
            var lonSecond = (double)(second.Longitude ?? 0);
            var theta = lonFirst - lonSecond;
            var dist = Math.Sin(Deg2Rad(latFirst))
                * Math.Sin(Deg2Rad(latSecond))
                + Math.Cos(Deg2Rad(latFirst))
                * Math.Cos(Deg2Rad(latSecond))
                * Math.Cos(Deg2Rad(theta));
            dist = Math.Acos(dist);
            dist = Rad2Deg(dist);
            dist = Convert(dist * 60 * 1.1515, unit);

            return (decimal)dist;
        }

        private static double Deg2Rad(double deg)
        {
            return (deg * Math.PI / 180.0);
        }

        private static double Rad2Deg(double rad)
        {
            return (rad / Math.PI * 180.0);
        }

        private static double Convert(double dist, RoutingDistanceUnit unit)
        {
            if (unit == RoutingDistanceUnit.Kilometer)
            {
                dist = dist * 1.609344;
            }
            else if (unit == RoutingDistanceUnit.NauticalMile)
            {
                dist = dist * 0.8684;
            }
            return dist;
        }
    }
}
