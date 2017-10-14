namespace SnapMD.VirtualCare.ApiModels
{
    public static class AddressObjectExtensions
    {
        public static bool SafeIsEmpty(this AddressObject addressObject)
        {
            return addressObject == null || addressObject.IsEmpty();
        }
    }
}
