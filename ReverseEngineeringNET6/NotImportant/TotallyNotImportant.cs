using System.Security.Cryptography;
using System.Text;

namespace ReverseEngineeringNET6.NotImportant
{
    public class TotallyNotImportant
    {
        private string totallyNotTheKey = string.Empty;

        public string TotallyNotTheKey()
        {
            totallyNotTheKey = RedHerring("koopa");
            return totallyNotTheKey;
        }

        private static byte[] GetHash(string inputString)
        {
            using HashAlgorithm algorithm = SHA256.Create();
            return algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputString));
        }

        private static string GetHashString(string inputString)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in GetHash(inputString))
                sb.Append(b.ToString("X2"));

            return sb.ToString();
        }

        private string RedHerring(string key)
        {
            string hash = GetHashString(key);
            return hash;
        }
    }
}