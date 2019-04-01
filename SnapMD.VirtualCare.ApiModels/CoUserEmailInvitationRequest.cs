using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapMD.VirtualCare.ApiModels
{
    /// <summary>
    /// The object CoUserEmailInvitationRequest.
    /// </summary>
    public class CoUserEmailInvitationRequest
    {
        /// <summary>
        /// HospitalId.
        /// </summary>
        public int? HospitalId { get; set; }

        /// <summary>
        /// UserId.
        /// </summary>
        public int? UserId { get; set; }

        /// <summary>
        /// Name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Email.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Token.
        /// </summary>
        public string Token { get; set; }
    }
}
