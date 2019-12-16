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
        /// The DefaultCountry of the provider.
        /// </summary>
        string DefaultCountry { get; set; }

        /// <summary>
        /// The Currency of the provider.
        /// </summary>
        Currency Currency { get; set; }

        /// <summary>
        /// The Patient Minimum Age of the provider.
        /// </summary>
        string PatientMinimumAge { get; set; }

        /// <summary>
        /// The Help Center Url of the provider.
        /// </summary>
        string HelpCenterUrl { get; set; }

        /// <summary>
        /// The dictionary of hospital settings.
        /// </summary>
        IDictionary<string, string> Settings { get; set; }
    }
}
