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
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens;
using System.Security.Claims;
using SecurityToken = System.IdentityModel.Tokens.SecurityToken;
using SigningCredentials = System.IdentityModel.Tokens.SigningCredentials;

namespace SnapMD.VirtualCare.LeopardonSso
{
    public abstract class AbstractJwt
    {
        protected readonly JwtSecurityTokenHandler SecurityTokenHandler = new JwtSecurityTokenHandler();

        protected virtual string Audience { get; }

        protected virtual string Issuer { get; }

        protected virtual SignatureProvider SignatureProvider => null;

        protected abstract SigningCredentials SigningCredentials { get; }

        protected virtual TokenValidationParameters TokenValidationParameters => 
            new TokenValidationParameters
            {
                ValidAudience = Audience,
                ValidIssuer = Issuer
            };

        public virtual ClaimsPrincipal Parse(string token)
        {
            SecurityToken securityToken;
            return SecurityTokenHandler.ValidateToken(token, TokenValidationParameters, out securityToken);
        }

        protected virtual string CreateToken(List<Claim> claims, bool encrypted = true)
        {
            if (claims == null)
            {
                throw new ArgumentNullException("claims");
            }

            var token = SecurityTokenHandler.CreateToken(
                subject: new ClaimsIdentity(claims),
                audience: Audience,
                issuer: Issuer,
                signingCredentials: SigningCredentials,
                signatureProvider: SignatureProvider);

            return encrypted ? SecurityTokenHandler.WriteToken(token) : token.ToString();
        }
    }
}
