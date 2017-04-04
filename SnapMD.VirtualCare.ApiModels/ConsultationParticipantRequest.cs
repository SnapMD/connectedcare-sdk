using System;

namespace SnapMD.VirtualCare.ApiModels
{
    /// <summary>
    /// The object used to encapsulate a consultation participant.
    /// </summary>
    public class ConsultationParticipantRequest
    {
    	/// <summary>
    	/// The ID of the participant, when viewed as ever having been a participant in a consultation.
    	/// </summary>
    	/// <remarks>
    	/// This is distinct from a person ID, which always stays the same.
    	/// A single person could have multiple participant ID's, depending on their consultations.
    	/// </remarks> 
        public Guid? ParticipantId { get; set; }

        /// <summary>
        /// The type of participant.
        /// </summary>
        /// <remarks>
        /// 1. Patient
        /// 2. Practitioner
        /// 3. Related Person
        /// </remarks>
        public int? ParticipantType { get; set; }

        /// <summary>
        /// The first name of the participant.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// The last name of the participant.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// The email address of the participant
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// The URL where a participant's profile picture is stored.
        /// </summary>
        public string PhotoUrl { get; set; }

        /// <summary>
        /// The content of a participant's profile picture.
        /// </summary>
        public byte[] PhotoContent { get; set; }
    }
}
