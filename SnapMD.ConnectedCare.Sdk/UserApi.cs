using System;

namespace SnapMD.ConnectedCare.Sdk
{
    public class UserApi : ApiCall
    {
        public UserApi(string baseUrl, string bearerToken, string developerId, string apiKey)
            : base(baseUrl, bearerToken, developerId, apiKey)
        {
        }

        public int? GetUserId()
        {
            var o = MakeCall("account/user");
            if (o != null && o["id"] != null)
            {
                var userId = Convert.ToInt32(o["id"]);
                return userId;
            }

            return null;
        }
    }
}