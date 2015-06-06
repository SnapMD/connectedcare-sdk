using System;

namespace SnapMD.Sdk
{
    public class UserCall : ApiCall
    {
        public UserCall(string baseUrl, string bearerToken, string developerId, string apiKey)
            : base(baseUrl, bearerToken, developerId, apiKey)
        {
        }

        public int GetUserId()
        {
            int userId;
            //var baseUrl = new Uri(_baseUrl);
            //var url = new Uri(baseUrl, "account/user");
            var o = MakeCall("account/user");
            userId = Convert.ToInt32(o["id"]);

            return userId;
        }
    }
}