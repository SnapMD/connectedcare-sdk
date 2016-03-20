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
    }
}
