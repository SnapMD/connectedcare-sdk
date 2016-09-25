using System.Collections.Generic;

namespace SnapMD.VirtualCare.ApiModels
{
	/// <summary>
	/// An interface encapsulating information about a hospital's settings.
	/// </summary>
    public interface IHospitalResponse
    {
    	/// <summary>
    	/// The list of modules enabled for a hospital.
    	/// </summary>
        List<string> EnabledModules { get; set; }

        /// <summary>
        /// The locale of the provider.
        /// </summary>
        string Locale { get; set; }

        /// <summary>
        /// The dictionary of hospital settings.
        /// </summary>
        IDictionary<string, string> Settings { get; set; }
    }
}
