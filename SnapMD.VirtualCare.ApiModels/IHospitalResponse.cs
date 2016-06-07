using System.Collections.Generic;

namespace SnapMD.VirtualCare.ApiModels
{
    public interface IHospitalResponse
    {
        List<string> EnabledModules { get; set; }

        string Locale { get; set; }

        IDictionary<string, string> Settings { get; set; }
    }
}
