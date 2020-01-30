using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace ProjektSzyfryPlutka
{
    class ClsCrypto
    {
        public ClsCrypto()
        {

        }



        public string md5encrypt(string phrase)
        {
            UTF8Encoding encoder = new UTF8Encoding();
            MD5CryptoServiceProvider md5Shasher = new MD5CryptoServiceProvider();
            byte[] hashedDataBytes = md5Shasher.ComputeHash(encoder.GetBytes(phrase));
            return byteArrayToString(hashedDataBytes);
        }
        public string sha1encrypt(string phrase)
        {
            UTF8Encoding encoder = new UTF8Encoding();
            SHA1CryptoServiceProvider mdShasher = new SHA1CryptoServiceProvider();
            byte[] hashedDataBytes = mdShasher.ComputeHash(encoder.GetBytes(phrase));
            return byteArrayToString(hashedDataBytes);
        }
        public string sha256encrypt(string phrase)
        {
            UTF8Encoding encoder = new UTF8Encoding();
            SHA256Managed sha256hasher = new SHA256Managed();
            byte[] hashedDataBytes = sha256hasher.ComputeHash(encoder.GetBytes(phrase));
            return byteArrayToString(hashedDataBytes);
        }

        public string sha384encrypt(string phrase)
        {
            UTF8Encoding encoder = new UTF8Encoding();
            SHA384Managed sha384hasher = new SHA384Managed();
            byte[] hashedDataBytes = sha384hasher.ComputeHash(encoder.GetBytes(phrase));
            return byteArrayToString(hashedDataBytes);
        }
        public string sha512encrypt(string phrase)
        {
            UTF8Encoding encoder = new UTF8Encoding();
            SHA512Managed sha512hasher = new SHA512Managed();
            byte[] hashedDataBytes = sha512hasher.ComputeHash(encoder.GetBytes(phrase));
            return byteArrayToString(hashedDataBytes);
        }
        public string byteArrayToString(byte[] inputArray)
        {
            StringBuilder output = new StringBuilder("");
            for (int i = 0; i < inputArray.Length; i++)
            {
                output.Append(inputArray[i].ToString("X2"));
            }
            return output.ToString();
        }
    
}
}
