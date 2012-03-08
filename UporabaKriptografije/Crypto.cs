using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Security.Cryptography;
using System.IO;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Crypto.Engines;

namespace UporabaKriptografije
{
    class Crypto
    {
        #region AES Fields

        private static string InitialVector = "oz7L3po*sjntl.ie";

        #endregion

        #region RSA Fields

        #endregion

        #region AES Methods

        public static byte[] EncryptAES(byte[] ClearData, byte[] Key)
        {
            MemoryStream ms = new MemoryStream();
            Rijndael RijAlg = Rijndael.Create();
            RijAlg.Key = Key;
            RijAlg.IV = Encoding.ASCII.GetBytes(InitialVector);
            CryptoStream cs = new CryptoStream(ms, RijAlg.CreateEncryptor(), CryptoStreamMode.Write);
            cs.Write(ClearData, 0, ClearData.Length);
            cs.Close();
            byte[] encryptedData = ms.ToArray();
            return encryptedData;
        }

        public static byte[] DecryptAES(byte[] CipherData, byte[] Key)
        {
            MemoryStream ms = new MemoryStream();
            Rijndael RijAlg = Rijndael.Create();
            RijAlg.Key = Key;
            RijAlg.IV = Encoding.ASCII.GetBytes(InitialVector);
            try
            {
                CryptoStream cs = new CryptoStream(ms, RijAlg.CreateDecryptor(), CryptoStreamMode.Write);
                cs.Write(CipherData, 0, CipherData.Length);
                cs.Close();
            }
            catch (CryptographicException e)
            {
                return null;
            }
            byte[] decryptedData = ms.ToArray();
            return decryptedData;
        }

        public static byte[] GenerateAESKey(int KeySize)
        {
            Rijndael RijAlg = Rijndael.Create();
            RijAlg.KeySize = KeySize;
            RijAlg.GenerateKey();
            return RijAlg.Key;
        }

        #endregion

        #region RSA Methods

        public static byte[] EncryptRSA(byte[] PlainData, AsymmetricKeyParameter Key)
        {
            RsaEngine Engine = new RsaEngine();
            Engine.Init(true, Key);

            int BlockSize = Engine.GetInputBlockSize();
            List<Byte> Output = new List<Byte>();

            for (int ChunkPosition = 0; ChunkPosition < PlainData.Length; ChunkPosition += BlockSize)
            {
                int ChunkSize = Math.Min(BlockSize, PlainData.Length -(ChunkPosition * BlockSize));
                Output.AddRange(Engine.ProcessBlock(PlainData, ChunkPosition, ChunkSize));
            }
            return Output.ToArray();
        }

        public static byte[] DecryptRSA(byte[] CipherData, AsymmetricKeyParameter Key)
        {
            RsaEngine Engine = new RsaEngine();
            Engine.Init(false, Key);

            int BlockSize = Engine.GetInputBlockSize();
            List<Byte> Output = new List<Byte>();

            for (int ChunkPosition = 0; ChunkPosition < CipherData.Length; ChunkPosition += BlockSize)
            {
                int ChunkSize = Math.Min(BlockSize, CipherData.Length - (ChunkPosition * BlockSize));
                Output.AddRange(Engine.ProcessBlock(CipherData, ChunkPosition, ChunkSize));
            }
            return Output.ToArray();
        }

        public static AsymmetricCipherKeyPair GenerateRSAKeys(int KeySize)
        {
            Debug.WriteLine(KeySize);
            RsaKeyPairGenerator r = new RsaKeyPairGenerator();
            r.Init(new KeyGenerationParameters(new SecureRandom(), KeySize));
            AsymmetricCipherKeyPair keys = r.GenerateKeyPair();
            return keys;
        }

        #endregion
    }
}
