using System;
using System.Security.Cryptography;
using System.Text;

namespace LojaCFF.Domain.Helpers
{
    public static class StringHelpers
    {
        public static string Encrypt(this string texto)
        {
            string salt = "CHAVEULTRASECRETA";

            var arrayBytes = Encoding.UTF8.GetBytes(texto + salt);

            byte[] hashBytes;

            using (var sha = SHA512.Create())
            {
                hashBytes = sha.ComputeHash(arrayBytes);
            }

            return Convert.ToBase64String(hashBytes);
        }
    }
}
