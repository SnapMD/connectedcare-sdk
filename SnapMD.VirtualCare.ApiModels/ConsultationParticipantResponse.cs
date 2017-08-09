using System;

namespace SnapMD.VirtualCare.ApiModels
{
    /// <summary>
    /// The object used to encapsulate a consultation participant after a change has been made.
    /// </summary>
    public class ConsultationParticipantResponse
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
        /// The unique ID of a person.
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// The id of consultation meeting (chat)
        /// </summary>
        public Guid? MeetingId { get; set; }
        
        /// <summary>
        /// The participant status
        /// </summary>
        public int Status { get; set; }

        /// <summary>
        /// The invitation email
        /// </summary>
        public string Email { get; set; }
    }
}
