
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace Common
{
    public class Encryption64
    {
        private static byte[] key = { };
        private static byte[] IV = { 0x12, 0x34, 0x56, 0x78, 0x90, 0xAB, 0xCD, 0xEF };

        public static string Encrypt( string strEncryptString, string strEncryptionKey)
        {
            byte[] inputByteArray;

            try
            {
                key = Encoding.UTF8.GetBytes(strEncryptionKey.Substring(0, 8));
                
                DESCryptoServiceProvider des = new DESCryptoServiceProvider();
                inputByteArray = Encoding.UTF8.GetBytes(strEncryptString);
                
                MemoryStream ms = new MemoryStream();
                CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(key, IV), CryptoStreamMode.Write);

                cs.Write(inputByteArray, 0, inputByteArray.Length);
                cs.FlushFinalBlock();

                return Convert.ToBase64String(ms.ToArray());
            }
            catch (Exception eX)
            {

                throw eX;
            }
        }

        public static string Decrypt(string strStringDecrypt, string strEncryptionKey)
        {
            byte[] inputByteArray = new byte[strStringDecrypt.Length];

            try
            {
                key = Encoding.UTF8.GetBytes(strEncryptionKey.Substring(0, 8));
                DESCryptoServiceProvider des = new DESCryptoServiceProvider();

                inputByteArray = Convert.FromBase64String(strStringDecrypt.Replace(" ", "+"));
                
                MemoryStream ms = new MemoryStream();
                CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(key, IV), CryptoStreamMode.Write);

                cs.Write(inputByteArray, 0, inputByteArray.Length);
                cs.FlushFinalBlock();

                Encoding encoding = Encoding.UTF8;
                return encoding.GetString(ms.ToArray());
            }
            catch (Exception eX)
            {
                
                throw eX;
            }
        }
    }
}
