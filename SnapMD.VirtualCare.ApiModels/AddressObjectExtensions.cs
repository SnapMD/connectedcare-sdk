namespace SnapMD.VirtualCare.ApiModels
{
    /// <summary>
    /// Represent the Address Object Extensions.
    /// </summary>
    public static class AddressObjectExtensions
    {
        /// <summary>
        ///  Represent the Safe Is Empty or not
        /// </summary>
        /// <value>
        /// Boolean value true or false
        /// </value>
        public static bool SafeIsEmpty(this AddressObject addressObject)
        {
            return addressObject == null || addressObject.IsEmpty();
        }
    }
}
