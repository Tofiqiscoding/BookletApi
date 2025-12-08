using System;
using System.Security.Cryptography;
using System.Text;
using System.Linq;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using BookletApi.Models;

namespace BookletApi.Utils
{
    public static class SecurityHelpers
    {
        public static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using var rng = RandomNumberGenerator.Create();
            passwordSalt = new byte[16];
            rng.GetBytes(passwordSalt);
            using var pbkdf2 = new Rfc2898DeriveBytes(password, passwordSalt, 100_000, HashAlgorithmName.SHA256);
            passwordHash = pbkdf2.GetBytes(32);
        }

        public static bool VerifyPassword(string password, byte[] storedHash, byte[] storedSalt)
        {
            using var pbkdf2 = new Rfc2898DeriveBytes(password, storedSalt, 100_000, HashAlgorithmName.SHA256);
            var calc = pbkdf2.GetBytes(32);
            return calc.SequenceEqual(storedHash);
        }

        public static string CreateJwtToken(User user, string jwtKey, string issuer, string audience)
        {
            var claims = new[] {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Email, user.Email),
                new Claim(ClaimTypes.Role, user.Role)
            };
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtKey));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken(
                issuer: issuer,
                audience: audience,
                claims: claims,
                expires: DateTime.UtcNow.AddMinutes(60),
                signingCredentials: creds
            );
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
