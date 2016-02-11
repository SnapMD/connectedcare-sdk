using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens;
using System.Security.Claims;

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
