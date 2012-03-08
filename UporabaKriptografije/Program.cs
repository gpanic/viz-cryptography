using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;
using System.Text;

namespace UporabaKriptografije
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            /*
            Debug.WriteLine("DEBUG START----------------------------------");
            byte[] key = Crypto.GenerateAESKey(128);
            byte[] enc = Crypto.EncryptAES(Encoding.UTF8.GetBytes("tojetestja"), key);
            byte[] dec = Crypto.DecryptAES(enc, key);
            //Util.WriteRSAKeys(Crypto.GenerateRSAKeys(1024),"C:/Users/Vision/Desktop/key.txt");
            byte[] encRSA = Crypto.EncryptRSA(Encoding.UTF8.GetBytes("tojenekitest"), Util.ReadRSAPublicKey("C:/Users/Vision/Desktop/key_public.txt"));
            byte[] decRSA = Crypto.DecryptRSA(encRSA, Util.ReadRSAPrivateKey("C:/Users/Vision/Desktop/key_private.txt"));
            Debug.WriteLine(Encoding.UTF8.GetString(decRSA));
            /*
            Debug.WriteLine(Util.ReadRSAPrivateKey("C:/Users/Vision/Desktop/key_private.txt").IsPrivate);
            Debug.WriteLine(Util.ReadRSAPublicKey("C:/Users/Vision/Desktop/key_public.txt").IsPrivate);
            */
            Application.Run(new GUI());
        }
    }
}
