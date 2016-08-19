using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace Dll
{
    public class Class1
    {
        static readonly string passHash = "P@SSw0rd";
        static readonly string sKey = "S@LT&KEY";
        static readonly string VIKey = "@1B2c3D4e5F6g7H8";

        public static string Encrypt(string plainText)
        {
            byte[] plainTextInBytes = Encoding.UTF8.GetBytes(plainText);

            byte[] keyInBytes = new Rfc2898DeriveBytes(passHash, Encoding.ASCII.GetBytes(sKey)).GetBytes(256 / 8);
            var symmetricKey = new RijndaelManaged() { Mode = CipherMode.CBC, Padding = PaddingMode.Zeros };
            var encryptor = symmetricKey.CreateEncryptor(keyInBytes, Encoding.ASCII.GetBytes(VIKey));

            byte[] cipherTextInBytes;

            using (var memoryStream = new MemoryStream())
            {
                using (var cryptalStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                {
                    cryptalStream.Write(plainTextInBytes, 0, plainTextInBytes.Length);
                    cryptalStream.FlushFinalBlock();
                    cipherTextInBytes = memoryStream.ToArray();
                    cryptalStream.Close();
                }
                memoryStream.Close();
            }
            return Convert.ToBase64String(cipherTextInBytes);
        }

        public static string Decrypt(string encryptedText)
        {
            byte[] cipherTextInBytes = Convert.FromBase64String(encryptedText);
            byte[] keyInBytes = new Rfc2898DeriveBytes(passHash, Encoding.ASCII.GetBytes(sKey)).GetBytes(256 / 8);
            var symmetricKey = new RijndaelManaged() { Mode = CipherMode.CBC, Padding = PaddingMode.None };

            var decryptor = symmetricKey.CreateDecryptor(keyInBytes, Encoding.ASCII.GetBytes(VIKey));
            var memoryStream = new MemoryStream(cipherTextInBytes);
            var cryptalStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);
            byte[] plainTextInBytes = new byte[cipherTextInBytes.Length];

            int decryptedByteCount = cryptalStream.Read(plainTextInBytes, 0, plainTextInBytes.Length);
            memoryStream.Close();
            cryptalStream.Close();
            return Encoding.UTF8.GetString(plainTextInBytes, 0, decryptedByteCount).TrimEnd("\0".ToCharArray());
        }
    }
}
