using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SnapMD.VirtualCare.ApiModels.Enums;
using SnapMD.VirtualCare.Sdk.Models;

namespace SnapMD.VirtualCare.Sdk.Interfaces
{
    /// <summary>
    /// Represent the Token Api.
    /// </summary>
    public interface ITokenApi
    {
        /// <summary>
        /// Generates an Api token 
        /// </summary>
        /// <param name="email">Email of the user</param>
        /// <param name="secret">Password of the user</param>
        /// <param name="userType">Type of user</param>
        /// <returns>Token string</returns>
        string GetToken(string email, string secret, UserType userType);

        /// <summary>
        /// Generates a token based on a jwt sso token
        /// </summary>
        /// <param name="jwt"></param>
        /// <returns>Token string</returns>
        string GetToken(string jwt);

        UserSessionRes GetUserSession(string email, string secret, UserType userType = UserType.Customer, int interfaceType = 0, string deviceId = null);
    }
}
