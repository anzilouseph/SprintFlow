using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SprintFlow.Application.Utillity
{
    public class PasswordHashHelper
    {
        private const int KeySize = 64;
        private const int Iterations = 350000;
        private static readonly HashAlgorithmName HashAlgorithm = HashAlgorithmName.SHA512;

        /// <summary>
        /// Hashes the password and generates a salt.
        /// </summary>
        public static string HashPassword(string password, out string salt)
        {

            if (password == null)
            {
            }
            var saltBytes = RandomNumberGenerator.GetBytes(KeySize);
            salt = Convert.ToBase64String(saltBytes);

            var hash = Rfc2898DeriveBytes.Pbkdf2(
                Encoding.UTF8.GetBytes(password),
                saltBytes,
                Iterations,
                HashAlgorithm,
                KeySize);

            return Convert.ToBase64String(hash);
        }

        /// <summary>
        /// Verifies the password against the stored hash and salt.
        /// </summary>
        public static bool VerifyPassword(string password, string storedHash, string storedSalt)
        {
            var saltBytes = Convert.FromBase64String(storedSalt);

            var hash = Rfc2898DeriveBytes.Pbkdf2(
                Encoding.UTF8.GetBytes(password),
                saltBytes,
                Iterations,
                HashAlgorithm,
                KeySize);

            return Convert.ToBase64String(hash) == storedHash;
        }
    }
}
