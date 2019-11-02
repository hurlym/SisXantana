using System;
using System.Text;
using System.Security.Cryptography;

namespace ClassBusiness
{
    public static class SHA
    {
        public static string Parse(string Text)
        {
            SHA1 SHA1 = new SHA1CryptoServiceProvider();
            byte[] PasswordBytes = (new UnicodeEncoding()).GetBytes(Text);
            byte[] Hash = SHA1.ComputeHash(PasswordBytes);
            return Convert.ToBase64String(Hash);
        }
    }
}
