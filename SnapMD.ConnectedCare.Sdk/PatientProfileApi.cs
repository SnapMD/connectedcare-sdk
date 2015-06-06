using Newtonsoft.Json.Linq;

namespace SnapMD.Sdk
{
    public class PatientProfileApi : ApiCall
    {
        public PatientProfileApi(string baseUrl, string bearerToken, string developerId, string apiKey)
            : base(baseUrl, bearerToken, developerId, apiKey)
        {
        }

        public JObject AddPatient(object newPatient)
        {
            // Todo: Create a request object to pass the data.
            return Post("patients/profile", newPatient);
        }

        // todo: short time implementatin. this has to remove eventually: Han
        public JObject GetPatientData(int PatientId)
        {
            var url = string.Format("patients/profile/{0}", PatientId);
            var result = MakeCall(url);
            return result;
        }

        // todo: short time implementation: only update organization & location for user
        public string UpdateUserProfile(object data)
        {
            var o = Post("patients/updateuserprofile", data);
            return string.Empty;
        }
    }
}