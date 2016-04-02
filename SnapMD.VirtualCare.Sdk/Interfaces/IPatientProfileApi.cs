using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SnapMD.VirtualCare.ApiModels;
using SnapMD.VirtualCare.Sdk.Models;

namespace SnapMD.VirtualCare.Sdk.Interfaces
{
    public interface IPatientProfileApi
    {
        ApiResponseV2<GetPatientsResponse> GetPatientData(int patientId);

        ApiResponseV2<NewPatientResponse> NewPatient(NewPatientRequest request);
        
        /// <summary>
        /// Re-sends patient onboarding email.
        /// </summary>
        /// <returns>Returns user's email address.</returns>
        ApiResponseV2<string> ResendOnboardingEmail(EmailUserRequest emailUserRequest);
    }
}
