//using System;
//using System.IO;
//using System.Security.Cryptography;
//using System.Text;

//namespace PassworAgain
//{
    

//    public static class EncryptionHelper
//    {
//        private static readonly string EncryptionKey = "your-secret-encryption-key";  // Use a secure key in production!

//        // Encrypt data
//        public static string Encrypt(string plainText)
//        {
//            using (Aes aesAlg = Aes.Create())
//            {
//                aesAlg.Key = Encoding.UTF8.GetBytes(EncryptionKey);
//                aesAlg.IV = new byte[16]; // Initialize IV to 0's (not recommended for production)

//                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);
//                using (MemoryStream msEncrypt = new MemoryStream())
//                {
//                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
//                    {
//                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
//                        {
//                            swEncrypt.Write(plainText);
//                        }
//                    }
//                    return Convert.ToBase64String(msEncrypt.ToArray());
//                }
//            }
//        }

//        // Decrypt data
//        public static string Decrypt(string cipherText)
//        {
//            using (Aes aesAlg = Aes.Create())
//            {
//                aesAlg.Key = Encoding.UTF8.GetBytes(EncryptionKey);
//                aesAlg.IV = new byte[16];  // Initialize IV to 0's (not recommended for production)

//                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);
//                using (MemoryStream msDecrypt = new MemoryStream(Convert.FromBase64String(cipherText)))
//                {
//                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
//                    {
//                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
//                        {
//                            return srDecrypt.ReadToEnd();
//                        }
//                    }
//                }
//            }
//        }
//    }
//}
