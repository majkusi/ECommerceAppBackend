using System.Security.Cryptography;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ECommerceAppBackend.Services.Register;

public class PasswordService
{
    public string HashPassword(string password)
    {
        byte[] salt;
        byte[] buffer2;
        if (password == null)
        {
            throw new ArgumentNullException("password");
        }

        using (Rfc2898DeriveBytes bytes = new Rfc2898DeriveBytes(password, 32, 10000, HashAlgorithmName.SHA512))
        {
            salt = bytes.Salt;
            buffer2 = bytes.GetBytes(32);
        }

        byte[] dst = new byte[49];
        Buffer.BlockCopy(salt, 0, dst, 1, 16);
        Buffer.BlockCopy(buffer2, 0, dst, 17, 32);
        return Convert.ToBase64String(dst);
    }

    public bool VerifyHashedPassword(string hashedPassword, string password)
    {
        byte[] buffer4;
        if (hashedPassword == null)
        {
            return false;
        }

        if (password == null)
        {
            throw new ArgumentNullException(nameof(password));
        }

        byte[] src = Convert.FromBase64String(hashedPassword);
        if ((src.Length != 49) || (src[0] != 0))
        {
            return false;
        }

        byte[] dst = new byte[16];
        Buffer.BlockCopy(src, 1, dst, 0, 16);
        byte[] buffer3 = new byte[32];
        Buffer.BlockCopy(src, 17, buffer3, 0, 32);
        using (Rfc2898DeriveBytes bytes = new Rfc2898DeriveBytes(password, dst, 10000, HashAlgorithmName.SHA512))
        {
            buffer4 = bytes.GetBytes(32);
        }

        return buffer3.SequenceEqual(buffer4);
    }
}
