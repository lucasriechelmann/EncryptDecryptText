using System.Security.Cryptography;
using System.Text;

namespace EncryptDecryptText
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        string AdjustKeySize(string key)
        {
            int targetKeySize = 32;

            if (key.Length >= targetKeySize)
            {
                // If the key is already equal to or longer than the target size, use it as is
                return key.Substring(0, targetKeySize);
            }
            else
            {
                // If the key is shorter than the target size, pad it with zeros at the start
                int paddingLength = targetKeySize - key.Length;
                string paddedKey = new string('0', paddingLength) + key;
                return paddedKey;
            }
        }

        string EncryptText(string plainText, string key)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Encoding.UTF8.GetBytes(key);
                aesAlg.IV = new byte[aesAlg.BlockSize / 8]; // Use a zero IV for simplicity

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(plainText);
                        }
                    }
                    return Convert.ToBase64String(msEncrypt.ToArray());
                }
            }
        }

        string DecryptText(string cipherText, string key)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Encoding.UTF8.GetBytes(key);
                aesAlg.IV = new byte[aesAlg.BlockSize / 8]; // Use a zero IV for simplicity

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msDecrypt = new MemoryStream(Convert.FromBase64String(cipherText)))
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

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            txtOutput.Text = EncryptText(txtInput.Text, AdjustKeySize(txtPassword.Text));
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            txtOutput.Text = DecryptText(txtInput.Text, AdjustKeySize(txtPassword.Text));
        }
    }
}