using System;
using SnapMD.Web.Api.Models;
using System.Collections.Generic;

namespace SnapMD.VirtualCare.ApiModels
{
    /// <summary>
    /// The API uses JSON camel case serialization, so the variables supplied in the incoming request will have lower case.
    /// </summary>
    public class ProfilesLocationRequest
    {
        /// <summary>
        ///   Get or Set Organization Id .
        /// </summary>
        /// <value>
        ///    Organization Id
        /// </value> 
        public int? OrganizationId { get; set; }
        /// <summary>
        ///   Get or Set Location Id.
        /// </summary>
        /// <value>
        ///   Location Id
        /// </value> 
        public int? LocationId { get; set; }
        /// <summary>
        ///  Get or Set Profile Ids.
        /// </summary>
        /// <value>
        ///  Profile Ids
        /// </value>
        public int[] ProfileIds { get; set; }
    }

 
}