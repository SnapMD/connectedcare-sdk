namespace SnapMD.Sdk
{
    public class EncountersApi : ApiCall
    {
        public EncountersApi(string baseUrl, string bearerToken, string developerId, string apiKey)
            : base(baseUrl, bearerToken, developerId, apiKey)
        {
        }

        public void UpdateIntakeQuestionnaire(int consultationId, object intakeData)
        {
            var url = string.Format("v2/patients/consultations/{0}/intake", consultationId);
            var result = Put(url, intakeData);
        }
    }
}