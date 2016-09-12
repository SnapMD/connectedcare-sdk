namespace SnapMD.VirtualCare.ApiModels
{
    /// <summary>
    /// Legacy interface for allergies.
    /// </summary>
    public interface ILegacyAllergyAdapter
    {

        /// <summary>
        /// Gets or sets the allergic medication1.
        /// </summary>
        /// <value>
        /// The allergic medication1.
        /// </value>
        int? AllergicMedication1 { get; set; }

        /// <summary>
        /// Gets or sets the allergic medication2.
        /// </summary>
        /// <value>
        /// The allergic medication2.
        /// </value>
        int? AllergicMedication2 { get; set; }

        /// <summary>
        /// Gets or sets the allergic medication3.
        /// </summary>
        /// <value>
        /// The allergic medication3.
        /// </value>
        int? AllergicMedication3 { get; set; }

        /// <summary>
        /// Gets or sets the allergic medication4.
        /// </summary>
        /// <value>
        /// The allergic medication4.
        /// </value>
        int? AllergicMedication4 { get; set; }
    }
}