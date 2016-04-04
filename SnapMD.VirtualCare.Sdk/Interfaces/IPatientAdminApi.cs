using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SnapMD.VirtualCare.ApiModels;
using SnapMD.VirtualCare.Sdk.Models;

namespace SnapMD.VirtualCare.Sdk.Interfaces
{
    public interface IPatientAdminApi
    {
        ApiResponse<PatientOnBoardShortDetail> GetPatient(string email);
        ApiResponseV2<AddPatientAdminResponseShort> AddPatient(PatientOnBoardShortDetail patient);
        void DeletePatient(int patientId);
    }
}
