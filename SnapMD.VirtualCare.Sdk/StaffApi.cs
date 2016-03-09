using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SnapMD.VirtualCare.ApiModels;
using SnapMD.VirtualCare.Sdk.Interfaces;
using SnapMD.VirtualCare.Sdk.Models;

namespace SnapMD.VirtualCare.Sdk
{
    public class StaffApi : ApiCall, IStaffApi
    {
        public StaffApi(string baseUrl, IWebClient client, string bearerToken = null, string developerId = null, string apiKey = null) : base(baseUrl, client, bearerToken, developerId, apiKey)
        {
        }


        public ApiResponseV2<CreateStaffProfileResponse> NewStaffProfile(StaffProfileRequest request)
        {
            var result = MakeCall<ApiResponseV2<CreateStaffProfileResponse>>("v2/clinicians/staffprofile");
            return result;
        }
    }
}
