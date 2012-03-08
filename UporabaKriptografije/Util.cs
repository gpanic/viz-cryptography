using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.OpenSsl;
using System.Diagnostics;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Pkcs;
using Org.BouncyCastle.Crypto.Parameters;

namespace UporabaKriptografije
{
    class Util
    {
        public static byte[] ReadFile(string FilePath)
        {
            FileStream fs = new FileStream(FilePath, FileMode.Open, FileAccess.Read);
            try
            {
                byte[] Bytes = new byte[fs.Length];
                fs.Read(Bytes, 0, Convert.ToInt32(fs.Length));
                fs.Close();
                return Bytes;
            }
            finally
            {
                fs.Close();
            }
        }

        public static void WriteRSAKeys(AsymmetricCipherKeyPair Keys, string Path)
        {
            AsymmetricKeyParameter PublicKey = Keys.Public;
            AsymmetricKeyParameter PrivateKey = Keys.Private;
            string Extension = System.IO.Path.GetExtension(Path);
            string PublicPath = (Extension.Length != 0) ? Path.Replace(Extension, "_public" + Extension) : Path + "_public";
            string PrivatePath = (Extension.Length != 0) ? Path.Replace(Extension, "_private" + Extension) : Path + "_private";

            TextWriter tw = new StreamWriter(PublicPath);
            PemWriter pw = new PemWriter(tw);
            pw.WriteObject(PublicKey);
            pw.Writer.Flush();
            pw.Writer.Close();
            tw.Close();

            tw = new StreamWriter(PrivatePath);
            pw = new PemWriter(tw);
            pw.WriteObject(PrivateKey);
            pw.Writer.Flush();
            pw.Writer.Close();
            tw.Close();
        }

        public static AsymmetricKeyParameter ReadRSAPublicKey(string Path)
        {
            try
            {
                string FileName = System.IO.Path.GetFileNameWithoutExtension(Path);
                if (FileName.Contains("_public"))
                {
                    RsaKeyParameters RSAKey;
                    TextReader tr = new StreamReader(Path);
                    PemReader pr = new PemReader(tr);
                    RSAKey = (RsaKeyParameters)pr.ReadObject();
                    AsymmetricKeyParameter Key = (AsymmetricKeyParameter)RSAKey;
                    pr.Reader.Close();
                    tr.Close();
                    return Key;
                }
                else
                {
                    return null;
                }
            }
            catch (InvalidCastException e)
            {
                return null;
            }
        }

        public static AsymmetricKeyParameter ReadRSAPrivateKey(string Path)
        {
            try
            {
                string FileName = System.IO.Path.GetFileNameWithoutExtension(Path);
                if (FileName.Contains("_private"))
                {
                    AsymmetricCipherKeyPair Key;
                    TextReader tr = new StreamReader(Path);
                    PemReader pr = new PemReader(tr);
                    Key = (AsymmetricCipherKeyPair)pr.ReadObject();
                    pr.Reader.Close();
                    tr.Close();
                    return Key.Private;
                }
                else
                {
                    return null;
                }
            }
            catch (InvalidCastException e)
            {
                return null;
            }
        }

    }
}