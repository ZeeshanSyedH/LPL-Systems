using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace LPLSystems.Services
{
    public static class Encryption
    {
        private static Random random = new Random();
        private static string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

        public static string ComputeHash(string input, string salt)
        {
            byte[] saltBytes = Encoding.UTF8.GetBytes(salt);
            return ComputeHash(input, saltBytes, new SHA256CryptoServiceProvider());
        }

        public static string RandomString()
        {
            return new string(
                Enumerable.Repeat(chars, 45).Select(s => s[random.Next(s.Length)]).ToArray()
            );
        }

        private static string ComputeHash(string input, byte[] salt, HashAlgorithm algorithm)
        {
            byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            byte[] saltedInput = new byte[salt.Length + inputBytes.Length];

            salt.CopyTo(saltedInput, 0);
            inputBytes.CopyTo(saltedInput, salt.Length);

            byte[] hashedBytes = algorithm.ComputeHash(saltedInput);

            return Convert.ToBase64String(hashedBytes);
        }
    }
}
