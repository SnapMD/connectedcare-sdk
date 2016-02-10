using System;
using System.Security.Cryptography;
using System.Threading.Tasks;
using SnapMD.VirtualCare.LeopardonSso.Properties;

namespace SnapMD.VirtualCare.LeopardonSso
{
    public class JwtCompiler : IDisposable
    {
        private readonly RSA _rsa;
        private bool _disposed;
        private readonly string _issuer;

        public JwtCompiler(string issuer, RSA rsa)
        {
            _issuer = issuer;
            _rsa = rsa;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public async Task<string> GetRedirectPath(string name, string email)
        {
            var token = await BuildJwtAsync(name, email);
            return string.Format(Settings.Default.JwtSignOnUrl, token);
        }

        private Task<string> BuildJwtAsync(string name, string email)
        {
            return Task.Run(() =>
            {
                var accessToken = BuildJwt(name, email);
                return accessToken;
            });
        }

        private string BuildJwt(string name, string email)
        {
            // Decrypt with private key using Jose JWT library
            var jwtToken = new WaltherJwt(_issuer, _rsa);
            var identity = jwtToken.Encode(name, email);
            return identity;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposing || _disposed)
            {
                return;
            }

            _rsa.Dispose();
            _disposed = true;
        }
    }

    public abstract class TokenIdentity
    {
        public string Email { get; set; }

        public abstract bool IsDisabled();
    }

    public class LoginRequest
    {
        public string Email { get; set; }

        public bool IsValid => !string.IsNullOrWhiteSpace(Email) && !string.IsNullOrWhiteSpace(Password);

        public string Password { get; set; }
    }
}
