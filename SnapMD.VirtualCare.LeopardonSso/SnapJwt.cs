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
using System.Linq;
using System.Security.Claims;

namespace SnapMD.VirtualCare.LeopardonSso
{
    public class SnapJwt : AbstractJwt
    {
        public static readonly string[] Roles = new[] { "patient", "clinician", "provider", "admin" };

        private const string Role = "patient";
        private readonly string _issuer;
        protected readonly SecurityKey SecurityKey;

        public SnapJwt(string issuer, SecurityKey securityKey)
        {
            _issuer = issuer;
            SecurityKey = securityKey;
        }

        protected override string Audience => @"snapmd";

        protected override string Issuer => _issuer;

        protected override SigningCredentials SigningCredentials =>
            new SigningCredentials(SecurityKey,
                "http://www.w3.org/2001/04/xmldsig-more#hmac-sha512",
                "http://www.w3.org/2001/04/xmlenc#sha512");

        protected override TokenValidationParameters TokenValidationParameters
        {
            get
            {
                var parameters = base.TokenValidationParameters;
                parameters.IssuerSigningKey = SecurityKey;
                return parameters;
            }
        }

        public string Write(string name, string email)
        {
            return CreateToken(CreateClaims(name, email), false);
        }

        public string Encode(string name, string email, Guid? jti = null)
        {
            return CreateToken(CreateClaims(name, email, jti));
        }

        protected virtual List<Claim> CreateClaims(string name, string email, Guid? jti = null)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, name),
                new Claim(ClaimTypes.Email, email),
                new Claim(ClaimTypes.Role, Role)
            };

            if (jti.HasValue)
                claims.Add(new Claim("jti", $"{jti}"));

            return claims;
        }

        public static void ValidateRole(string role)
        {
            if (!Roles.Contains(role))
            {
                throw new ArgumentOutOfRangeException("Invalid Role");
            }
        }
    }
}
