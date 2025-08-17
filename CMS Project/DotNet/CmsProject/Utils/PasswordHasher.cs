using System.Security.Cryptography;
using System.Text;

namespace CmsProject.Utils
{
    public class PasswordHasher
    {
        public static byte[] HashSha256(string? input)
        {
            if (string.IsNullOrWhiteSpace(input)) return Array.Empty<byte>();
            using var sha = SHA256.Create();
            return sha.ComputeHash(Encoding.UTF8.GetBytes(input));
        }
    }
}
