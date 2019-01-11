using System.Net;
using SnapMD.VirtualCare.ApiModels;
using SnapMD.VirtualCare.Sdk.Interfaces;

namespace SnapMD.VirtualCare.Sdk
{
    /// <summary>
    /// Represents Person Api.
    /// </summary>
    public class PersonApi : ApiCall, IPersonApi
    {
        /// <summary>
        /// Constructor of PaymentsApi.
        /// </summary>
        /// <param name="apiKey"></param>
        /// <param name="baseUrl"></param>
        /// <param name="bearerToken"></param>
        /// <param name="developerId"></param>
        /// <param name="client"></param>
        public PersonApi(string baseUrl, IWebClient client, string bearerToken = null, string developerId = null, string apiKey = null) : base(baseUrl, client, bearerToken, developerId, apiKey)
        {
        }

        /// <summary>
        ///Get the person by Email.
        /// </summary>
        /// <param name="email">Person email</param>
        /// <param name="userType">User Type</param>
        public ApiResponseV2<PersonRecord> GetPersonByEmail(string email, int? userType = null)
        {
            var encodedEmail = WebUtility.HtmlEncode(email);

            return MakeCall<ApiResponseV2<PersonRecord>>($"v2.1/people?email={encodedEmail}&userType={userType}");
        }

        /// <summary>
        ///Get the Clinician Person.
        /// </summary>
        /// <param name="providerId">Provider Id</param>
        /// <param name="clinicianUserId">Clinician User Id</param>
        public ApiResponseV2<ClinicianPersonResponse> GetClinicianPerson(int providerId, int clinicianUserId)
        {
            return
                MakeCall<ApiResponseV2<ClinicianPersonResponse>>(
                    $"v2.1/providers/{providerId}/users/{clinicianUserId}/clinician/person");
        }

        /// <summary>
        ///Get the Patient Person.
        /// </summary>
        /// <param name="providerId">Provider Id</param>
        /// <param name="patientId">Patient Id</param>
        public ApiResponseV2<PatientPersonResponse> GetPatientPerson(int providerId, int patientId)
        {
            return MakeCall<ApiResponseV2<PatientPersonResponse>>($"v2.1/providers/{providerId}/patients/{patientId}");
        }
    }
}
