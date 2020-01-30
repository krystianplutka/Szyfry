using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektSzyfryPlutka
{
    class SzyfrVigenere
    {
        public string encryptByteVigenere(string plaintext, string key)
        {
            Byte[] bytes = Encoding.ASCII.GetBytes(plaintext);
            Byte[] result = new Byte[plaintext.Length];

            key = key.Trim().ToUpper();

            int keyIndex = 0;
            int keylength = key.Length;

            for (int i = 0; i < plaintext.Length; i++)
            {
                keyIndex = keyIndex % keylength;
                int shift = (int)key[keyIndex] - 65;
                result[i] = (byte)(((int)plaintext[i] + shift) % 256);
                keyIndex++;
            }
            string szyfr = Encoding.ASCII.GetString(result);
            return szyfr;
        }

        public string decryptByteVigenere(string ciphertext, string key)
        {
            Byte[] bytes = Encoding.ASCII.GetBytes(ciphertext);
            Byte[] result = new Byte[bytes.Length];
            

            key = key.Trim().ToUpper();

            int keyIndex = 0;
            int keylength = key.Length;

            for (int i = 0; i < ciphertext.Length; i++)
            {
                keyIndex = keyIndex % keylength;
                int shift = (int)key[keyIndex] - 65;
                result[i] = (byte)(((int)ciphertext[i] + 256 - shift) % 256);
                keyIndex++;
            }
            string szyfr = Encoding.ASCII.GetString(result);
            return szyfr;
        }
    }
}
