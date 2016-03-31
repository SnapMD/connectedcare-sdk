using SnapMD.VirtualCare.ApiModels;
using SnapMD.VirtualCare.Sdk.Interfaces;
using SnapMD.VirtualCare.Sdk.Models;

namespace SnapMD.VirtualCare.Sdk
{
    public class PersonApi : ApiCall, IPersonApi
    {
        public PersonApi(string baseUrl, IWebClient client, string bearerToken = null, string developerId = null, string apiKey = null) : base(baseUrl, client, bearerToken, developerId, apiKey)
        {
        }

        public ApiResponseV2<PersonRecord> GetPersonByEmail(string email, int? userType = null)
        {
            return MakeCall<ApiResponseV2<PersonRecord>>($"v2.1/people/{email}?userType={userType}");
        }
    }
}
