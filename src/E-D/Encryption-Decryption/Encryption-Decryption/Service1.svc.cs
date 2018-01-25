using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Encryption_Decryption
{

    public class Service1 : EncryptDecryptServices
    {
        public string decryptString(string encryptString)
        {
            String decryptedString;
            MemoryStream memoryStream = new MemoryStream();
            String decryptionKey = "p@$W012D";
            byte[] decodekey;
            byte[] initialisationVector = { 7, 25, 19, 36, 11, 42, 67, 27 };
            byte[] encryptedStringByte = new byte[encryptString.Length];

            decodekey = Encoding.UTF8.GetBytes(decryptionKey);
            encryptedStringByte = Convert.FromBase64String(encryptString);

            DESCryptoServiceProvider desDecryptProvider = new DESCryptoServiceProvider();

            ICryptoTransform decryptTransform = desDecryptProvider.CreateDecryptor(decodekey, initialisationVector);

            CryptoStream cryptoStream = new CryptoStream(memoryStream, decryptTransform, CryptoStreamMode.Write);
            cryptoStream.Write(encryptedStringByte, 0, encryptedStringByte.Length);
            cryptoStream.FlushFinalBlock();

            decryptedString = Encoding.UTF8.GetString(memoryStream.ToArray());

            return decryptedString;
        }

        public string encryptString(string plainString)
        {
            MemoryStream memoryStream = new MemoryStream();
            String encryptedString;
            String encryptionKey = "p@$W012D";
            byte[] encodekey;
            byte[] initialisationVector = { 7, 25, 19, 36, 11, 42, 67, 27 };
            byte[] inputStringByte;

            encodekey = Encoding.UTF8.GetBytes(encryptionKey);
            inputStringByte = Encoding.UTF8.GetBytes(plainString);

            DESCryptoServiceProvider desCryptoProvider = new DESCryptoServiceProvider();

            ICryptoTransform cryptoTransform = desCryptoProvider.CreateEncryptor(encodekey, initialisationVector);

            CryptoStream cryptoStream = new CryptoStream(memoryStream, cryptoTransform, CryptoStreamMode.Write);
            cryptoStream.Write(inputStringByte, 0, inputStringByte.Length);
            cryptoStream.FlushFinalBlock();

            encryptedString = Convert.ToBase64String(memoryStream.ToArray());

            return encryptedString;
        }
    }
}
