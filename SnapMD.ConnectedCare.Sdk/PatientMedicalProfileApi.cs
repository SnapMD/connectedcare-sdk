using SnapMD.ConnectedCare.ApiModels;
using SnapMD.ConnectedCare.Sdk.Interfaces;
using SnapMD.ConnectedCare.Sdk.Models;

namespace SnapMD.ConnectedCare.Sdk
{
    public class PatientMedicalProfileApi : ApiCall
    {
        public PatientMedicalProfileApi(string baseUrl, string bearerToken, string developerId, string apiKey, IWebClient webClient)
            : base(baseUrl, webClient, bearerToken, developerId, apiKey)
        {
        }

        public ApiResponseV2<IPatientMedicalHistoryProfile> GetPatientData(int patientId)
        {
            var url = string.Format("v2/patients/medicalprofile/{0}", patientId);
            var result = MakeCall<ApiResponseV2<IPatientMedicalHistoryProfile>>(url);
            return result;
        }
    }
}
