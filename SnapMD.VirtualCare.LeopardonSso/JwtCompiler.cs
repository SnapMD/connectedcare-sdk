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

        public JwtCompiler(RSA rsa)
        {
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
            var jwtToken = new WaltherJwt("snapmd", _rsa);
            var identity = jwtToken.Encode(name, email);
            return identity;
        }

        protected void Dispose(bool disposing)
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
