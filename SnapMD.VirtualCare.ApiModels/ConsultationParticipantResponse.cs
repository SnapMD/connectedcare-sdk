using System;

namespace SnapMD.VirtualCare.ApiModels
{
	/// <summary>
	/// The object used to encapsulate a consultation participant after a change has been made.
	/// <summary>
    public class ConsultationParticipantResponse: ConsultationParticipantRequest
    {
    	/// <summary>
    	/// The unique ID of a person, which always stays the same
    	/// </summary>
        public Guid PersonId { get; set; }
    }
}
