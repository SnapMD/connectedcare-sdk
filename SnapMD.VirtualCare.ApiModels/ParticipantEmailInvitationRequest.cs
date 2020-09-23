#region Copyright
//    Copyright 2016 SnapMD, Inc.
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
//        http://www.apache.org/licenses/LICENSE-2.0
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.
#endregion
namespace SnapMD.VirtualCare.ApiModels
{
    /// <summary>
    ///    Encapsulate the Participant Email Invitation Request.
    /// </summary>
    public class ParticipantEmailInvitationRequest
    {
        /// <summary>
        ///     Gets or sets the Participant Name.
        /// </summary>
        /// <value>
        ///     Participant Name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        ///     Gets or sets the Participant Email address or phone.
        /// </summary>
        /// <value>
        ///     Participant Email address or phone.
        /// </value>
        public string EmailOrPhone { get; set; }

        /// <summary>
        ///     Gets or sets the Participant User Id.
        /// </summary>
        /// <value>
        ///     Participant UserId.
        /// </value>
        public int UserId { get; set; }
    }
}
