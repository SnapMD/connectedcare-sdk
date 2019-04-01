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
using System.Security.Cryptography;
using System.Threading.Tasks;
using SnapMD.VirtualCare.LeopardonSso.Properties;

namespace SnapMD.VirtualCare.LeopardonSso
{
    public class JwtCompiler : IDisposable
    {
        private readonly string _role;
        private readonly RSA _rsa;
        private bool _disposed;
        private readonly string _issuer;

        public string JwtSignOnUrl { get; set; }

        public JwtCompiler(string issuer, RSA rsa) : this(issuer, rsa, SnapJwt.Roles[0])
        {
        }

        public JwtCompiler(string issuer, RSA rsa, string role)
        {
            SnapJwt.ValidateRole(role);
            _role = role;
            _issuer = issuer;
            _rsa = rsa;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public async Task<string> GetRedirectPath(string name, string email, Guid? jti = null)
        {
            var signonUrl = JwtSignOnUrl ?? DefaultJwtSignOnUrl;
            var token = await BuildJwtAsync(name, email, jti);
            return string.Format(signonUrl, token);
        }

        private string DefaultJwtSignOnUrl =>
            _role == SnapJwt.Roles[0] ? Settings.Default.JwtSignOnUrl :
                (_role == "admin" ? Settings.Default.JwtAdminSignOnUrl : Settings.Default.JwtClincianSignOnUrl);

        private Task<string> BuildJwtAsync(string name, string email, Guid? jti = null)
        {
            return Task.Run(() =>
            {
                var accessToken = BuildJwt(name, email, jti);
                return accessToken;
            });
        }

        private string BuildJwt(string name, string email, Guid? jti = null)
        {
            // Decrypt with private key using Jose JWT library
            var jwtToken = new WaltherJwt(_issuer, _rsa, _role);
            var identity = jwtToken.Encode(name, email, jti);
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
