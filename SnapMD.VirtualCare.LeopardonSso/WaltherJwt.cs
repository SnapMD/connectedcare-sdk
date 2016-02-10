using System.Collections.Generic;
using System.IdentityModel.Tokens;
using System.Security.Claims;
using System.Security.Cryptography;

namespace SnapMD.VirtualCare.LeopardonSso
{
    public class WaltherJwt : SnapJwt
    {
        private const string Role = "patient";
        private readonly RSA _rsa;
        private readonly RsaSecurityKey _rsaSecurityKey;
        private readonly string _issuer;

        public WaltherJwt(string issuer, RSA rsa) : base(issuer, null)
        {
            _rsa = rsa;
            _issuer = issuer;
            _rsaSecurityKey = new RsaSecurityKey(rsa);
        }

        protected override string Audience => @"snapmd";

        protected override string Issuer => _issuer;

        protected override SignatureProvider SignatureProvider =>
            new AsymmetricSignatureProvider(
                _rsaSecurityKey,
                SecurityAlgorithms.RsaSha256Signature,
                true);

        protected override SigningCredentials SigningCredentials => 
            new SigningCredentials(
                _rsaSecurityKey,
                SecurityAlgorithms.RsaSha256Signature,
                SecurityAlgorithms.Sha256Digest);

        protected override TokenValidationParameters TokenValidationParameters
        {
            get
            {
                var parameters = base.TokenValidationParameters;
                parameters.IssuerSigningToken = new RsaSecurityToken(_rsa);
                parameters.IssuerSigningKeyResolver =
                    (tokenString, token, keyIdentifier, validationParameters) => _rsaSecurityKey;
                return parameters;
            }
        }

        protected override List<Claim> CreateClaims(string name, string email)
        {
            return new List<Claim>
            {
                new Claim(ClaimTypes.Name, name),
                new Claim(ClaimTypes.Email, email),
                new Claim(ClaimTypes.Role, Role)
            };
        }
    }
}
