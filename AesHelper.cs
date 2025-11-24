using System.IO;
using System.Security.Cryptography;

namespace WiiLink_Desktop_CS
{
    public class AesHelper
    {
        private byte[] key;
        private byte[] iv;

        public AesHelper(byte[] key, byte[] iv)
        {
            this.key = key;
            this.iv = iv;
        }

        public string Decrypt(byte[] encryptedData)
        {
            using (AesManaged aesAlg = new AesManaged())
            {
                aesAlg.Key = key;
                aesAlg.IV = iv;
                aesAlg.Mode = CipherMode.CBC;
                aesAlg.Padding = PaddingMode.PKCS7;

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msDecrypt = new MemoryStream(encryptedData))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            return srDecrypt.ReadToEnd();
                        }
                    }
                }
            }
        }
    }
}
