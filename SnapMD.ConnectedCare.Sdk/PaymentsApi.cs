using Newtonsoft.Json.Linq;
using SnapMD.ConnectedCare.Sdk.Models;

namespace SnapMD.ConnectedCare.Sdk
{
    public class PaymentsApi : ApiCall
    {
        public PaymentsApi(string baseUrl, string bearerToken, int hospitalId, string developerId, string apiKey)
            : base(baseUrl, bearerToken, developerId, apiKey)
        {
            HospitalId = hospitalId;
        }

        public PaymentsApi(string baseUrl, int hospitalId)
            : base(baseUrl)
        {
            HospitalId = hospitalId;
        }

        public int HospitalId { get; private set; }

        public JObject GetCustomerProfile(int userId)
        {
            var result = MakeCall(string.Format("patients/{0}/payments", userId));
            return result;
        }

        public JObject RegisterProfile(int userId, object paymentData)
        {
            var result = Post(string.Format("patients/{0}/payments", userId), paymentData);
            return result;
        }

        public ApiResponse GetPaymentStatus(int consultationId)
        {
            var result = MakeCall<ApiResponse>(string.Format("patients/copay/{0}/paymentstatus", consultationId));
            return result;
        }
    }
}