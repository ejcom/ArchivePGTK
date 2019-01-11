using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace ArchivePGTK
{
    public static class Buffer
    {
        public static int MFFinalmarks = 0;
        public static int MFPersonBuffer = 0;
        public static int MFCardsBuffer = 0;
        public static string State = "view";
    }

    class DataToCB
    {
        public readonly int Value;
        public readonly string Text;

        public DataToCB(int Value, string Text)
        {
            this.Value = Value;
            this.Text = Text;
        }

        public override string ToString()
        {
            return this.Text;
        }
    }

    
    public static class AES
    {
        public static string Encrypt(string encryptedText, string password, string keySecond = "ejcom", string hashAlgorithm = "SHA1", int passwordIterations = 3, string initialVector = "zFRna73Om*ae01yY", int keySize = 256)
        {
            if (string.IsNullOrEmpty(encryptedText))
                return "";

            byte[] initialVectorBytes = Encoding.ASCII.GetBytes(initialVector);
            byte[] keySecondValueBytes = Encoding.ASCII.GetBytes(keySecond);
            byte[] encryptedTextBytes = Encoding.UTF8.GetBytes(encryptedText);

            PasswordDeriveBytes derivedPassword = new PasswordDeriveBytes(password, keySecondValueBytes, hashAlgorithm, passwordIterations);
            byte[] keyBytes = derivedPassword.GetBytes(keySize / 8);
            RijndaelManaged symmetricKey = new RijndaelManaged();
            symmetricKey.Mode = CipherMode.CBC;

            byte[] cipherTextBytes = null;

            using (ICryptoTransform encryptor = symmetricKey.CreateEncryptor(keyBytes, initialVectorBytes))
            {
                using (MemoryStream memStream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream(memStream, encryptor, CryptoStreamMode.Write))
                    {
                        cryptoStream.Write(encryptedTextBytes, 0, encryptedTextBytes.Length);
                        cryptoStream.FlushFinalBlock();
                        cipherTextBytes = memStream.ToArray();
                        memStream.Close();
                        cryptoStream.Close();
                    }
                }
            }

            symmetricKey.Clear();
            return Convert.ToBase64String(cipherTextBytes);
        }

        public static string Decrypt(string cryptedText, string password, string keySecond = "ejcom", string hashAlgorithm = "SHA1", int passwordIterations = 3, string initialVector = "zFRna73Om*ae01yY", int keySize = 256)
        {
            if (string.IsNullOrEmpty(cryptedText))
                return "";

            byte[] initialVectorBytes = Encoding.ASCII.GetBytes(initialVector);
            byte[] keySecondValueBytes = Encoding.ASCII.GetBytes(keySecond);
            byte[] cryptedTextBytes = Convert.FromBase64String(cryptedText);

            PasswordDeriveBytes derivedPassword = new PasswordDeriveBytes(password, keySecondValueBytes, hashAlgorithm, passwordIterations);
            byte[] keyBytes = derivedPassword.GetBytes(keySize / 8);

            RijndaelManaged symmetricKey = new RijndaelManaged();
            symmetricKey.Mode = CipherMode.CBC;

            byte[] plainTextBytes = new byte[cryptedTextBytes.Length];
            int byteCount = 0;

            using (ICryptoTransform decryptor = symmetricKey.CreateDecryptor(keyBytes, initialVectorBytes))
            {
                using (MemoryStream memStream = new MemoryStream(cryptedTextBytes))
                {
                    using (CryptoStream cryptoStream = new CryptoStream(memStream, decryptor, CryptoStreamMode.Read))
                    {
                        byteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
                        memStream.Close();
                        cryptoStream.Close();
                    }
                }
            }

            symmetricKey.Clear();
            return Encoding.UTF8.GetString(plainTextBytes, 0, byteCount);
        }

    }
    
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }


}
