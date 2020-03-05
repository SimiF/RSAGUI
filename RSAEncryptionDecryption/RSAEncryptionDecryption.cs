using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RSA;

namespace RSAEncryptionDecryption_Name
{
    public class RSAEncryptionDecryption
    {
        public int[] publicKeys { get; set; }

        public void GenerateKeys()
        {
            publicKeys = RSAKeyGeneration.GenerateKeys();
        }

        public long Encrypt(long plainText)
        {
            long cipherText = 1;                        

            for (int i = 0; i < publicKeys[0]; ++i)
                cipherText = (cipherText * plainText) % publicKeys[1];

            return cipherText;         
        }

        public long Decrypt(long cipherText)
        {
            long plainText = 1;            

            for (int i = 0; i < publicKeys[5]; ++i)
                plainText = (plainText * cipherText) % publicKeys[1];

            return plainText;
        }
    }
}
