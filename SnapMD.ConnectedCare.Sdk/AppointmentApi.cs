using SnapMD.ConnectedCare.Sdk.Models;

namespace SnapMD.ConnectedCare.Sdk
{
    public class AppointmentApi : ApiCall
    {
        public AppointmentApi(string baseUrl, string bearerToken, string developerId, string apiKey)
            : base(baseUrl, bearerToken, developerId, apiKey)
        {
        }

        public bool IsValidAppointment(int appointmentId)
        {
            var result = MakeCall<ApiResponse>(string.Format("appointments/{0}?fields=expire", appointmentId));
            if (result.Success)
            {
                dynamic responseData = result.Data;
                return !((bool) responseData.expire);
            }
            return false;
        }
    }
}