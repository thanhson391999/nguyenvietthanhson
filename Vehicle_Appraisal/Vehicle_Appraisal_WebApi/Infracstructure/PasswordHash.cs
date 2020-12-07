using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System;

namespace Vehicle_Appraisal_WebApi.Infracstructure
{
    public class PasswordHash
    {
        public string HashPassword(string Password)
        {
            byte[] salt = new byte[128 / 8];
            var hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
            password: Password,
            salt: salt,
            prf: KeyDerivationPrf.HMACSHA256,
            iterationCount: 100000,
            numBytesRequested: 256 / 8));
            return hashed;
        }
    }
}
