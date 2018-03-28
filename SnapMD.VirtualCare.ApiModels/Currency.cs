using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapMD.VirtualCare.ApiModels
{
    /// <summary>
    /// Currency 
    /// </summary>
    public class Currency
    {
        /// <summary>
        /// Currency ID
        /// </summary>
        public string CurrencyId { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Currency Symbol
        /// </summary>
        public string CurrencySymbol { get; set; }

        /// <summary>
        /// Currency Abbr
        /// </summary>
        public string CurrencyAbbr { get; set; }
    }
}
