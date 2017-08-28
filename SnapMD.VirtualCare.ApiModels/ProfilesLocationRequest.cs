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
        public int? OrganizationId { get; set; }
        public int? LocationId { get; set; }
        public int[] ProfileIds { get; set; }
    }

 
}