using System;
using System.Security.Cryptography;
using System.Text;

namespace Cryptography.CAL
{
    public static class Algorithms
    {
        public static string GetSHA1(string text)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                byte[] sourceBytes = Encoding.UTF8.GetBytes(text);
                byte[] hashBytes = sha1.ComputeHash(sourceBytes);
                return BitConverter.ToString(hashBytes);
            }
        }
    }
}
