using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SnapMD.VirtualCare.ApiModels;
using SnapMD.VirtualCare.Sdk.Models;

namespace SnapMD.VirtualCare.Sdk.Interfaces
{
    /// <summary>
    /// Represent the Interface Patient Profile Api.
    /// </summary>
    public interface IPatientProfileApi
    {
        /// <summary>
        /// Get the Patient Data
        /// </summary>
        /// <param name="patientId"> Patient Id  </param>
        /// <returns>Pateint Data</returns>
        ApiResponseV2<GetPatientsResponse> GetPatientData(int patientId);

        /// <summary>
        /// Create the Patient
        /// </summary>
        /// <param name="request"> Patient Information </param>
        ApiResponseV2<NewPatientResponse> NewPatient(NewPatientRequest request);
        
        /// <summary>
        /// Re-sends patient onboarding email.
        /// </summary>
        /// <returns>Returns user's email address.</returns>
        ApiResponseV2<string> ResendOnboardingEmail(EmailUserRequest emailUserRequest);
    }
}
