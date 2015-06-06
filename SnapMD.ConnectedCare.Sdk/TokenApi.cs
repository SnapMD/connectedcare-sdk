namespace SnapMD.Sdk
{
    public class TokenApi : ApiCall
    {
        public TokenApi(string baseUrl, int hospitalId, string developerId, string apiKey)
            : base(baseUrl, developerId: developerId, apiKey: apiKey)
        {
            HospitalId = hospitalId;
        }

        public int HospitalId { get; private set; }

        public string GetToken(string email, string secret)
        {
            var request = new
            {
                email,
                hospitalId = HospitalId,
                password = secret,
                userTypeId = 1
            };

            var result = Post("account/token", request);
            return (string) result["access_token"];
        }
    }
}