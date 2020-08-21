using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HorseTipRepository
{
    /// <summary>
    /// This file processing class uses an interface connection to serialise data then encrypt or decrypt then deserialise
    /// depending on the users request.
    /// </summary>
    //Code can be refactored to seperate byte writer/reader and serialisers from encryption.
    public class FileEncryptor : IFileProcessor
    {

        private static int SerialLength;
        private IDataSerialiser dataSerialiser;
        private IByteProcessor byteProcessor;
        private byte[] serialisedHorseBets;

        private static readonly string KeyPath = "Key.txt";
        private static readonly string IVPath = "IV.txt";
        private static readonly string filePathName = "TipsData.txt";

        public FileEncryptor()
        {
            dataSerialiser = new DataSerialiser();
            byteProcessor = new ByteProcessor();
        }

        /// <summary>
        ///Writes an encrypted version of the binary Horse Tip data.
        /// </summary>
        /// <param name="horseBets"></param>
        public void WriteToFile(List<HorseTip> horseBets)
        {
            serialisedHorseBets = dataSerialiser.SerializeHorseTips(horseBets);
            SerialLength = serialisedHorseBets.Length;
            EncryptToFile(serialisedHorseBets);
        }
        /// <summary>
        /// Reads an encrypted horsetip binary file back into data on the system.
        /// </summary>
        /// <returns></returns>
        public List<HorseTip> ReadFromFile()
        {
            byte[] dataToDerserialise = DecryptFromFile();
            return dataSerialiser.DeserialiseBytes(dataToDerserialise);
        }

        /// <summary>
        /// Encrypts a byte array to a specified file.
        /// </summary>
        /// <param name="serialisedBytes"></param>
        private void EncryptToFile(byte[] serialisedBytes)
        {

            if (serialisedBytes == null)
            {
                throw new ArgumentNullException("Bytes");
            }

            //AES is the advanced encryption standard class for encryption it 
            using (AesCryptoServiceProvider encryptAlg = new AesCryptoServiceProvider())
            {
                //The priavte key is the cipher key used to lock and unlock the encryption.
                byte[] key = encryptAlg.Key;
                //The IV is the initialisation vector, a randomised block that is used to securely encrypt the data through cipher block chaining. 
                //Where the preceding block encryption output is used to affect the next one.
                byte[] iV = encryptAlg.IV;

                byteProcessor.SaveBytesToFile(KeyPath, key);
                byteProcessor.SaveBytesToFile(IVPath, iV);

                //Padding mode specifies the padding type when a data block is shorter thant the full number of bytes required. AES can use key lengths from  128 - 256 bytes.
                encryptAlg.Padding = PaddingMode.Zeros;

                using (ICryptoTransform transform = encryptAlg.CreateEncryptor(key, iV))
                {
                    using (FileStream fsBets = new FileStream(filePathName, FileMode.OpenOrCreate, FileAccess.ReadWrite))
                    {
                        using (CryptoStream csBets = new CryptoStream(fsBets, transform, CryptoStreamMode.Write))
                        {
                            try
                            {
                                csBets.Write(serialisedBytes, 0, SerialLength);
                                csBets.FlushFinalBlock();
                            }
                            catch (Exception ex)
                            {
                                throw ex;
                            }
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Decrypts a specific encrypted file into a byte array.
        /// </summary>
        /// <returns></returns>
        private byte[] DecryptFromFile()
        {
            byte[] decryptedBytes;
            byte[] decryptKey = byteProcessor.ReadBytesFromFile(KeyPath);
            byte[] decryptIV = byteProcessor.ReadBytesFromFile(IVPath);

            using (AesCryptoServiceProvider decryptAlg = new AesCryptoServiceProvider())
            {
                decryptAlg.Padding = PaddingMode.Zeros;


                if (decryptKey == null)
                {
                    throw new ArgumentNullException("Key");
                }
                if (decryptIV == null)
                {
                    throw new ArgumentNullException("IV");
                }
                using (ICryptoTransform dectyptor = decryptAlg.CreateDecryptor(decryptKey, decryptIV))
                {
                    using (FileStream fsBets = new FileStream(filePathName, FileMode.Open, FileAccess.Read))
                    {
                        using (CryptoStream csBets = new CryptoStream(fsBets, dectyptor, CryptoStreamMode.Read))
                        {
                            try
                            {
                                SerialLength = (int)fsBets.Length;
                                decryptedBytes = new byte[SerialLength];
                                csBets.Read(decryptedBytes, 0, SerialLength);
                            }
                            catch (Exception ex)
                            {
                                throw ex;
                            }
                        }
                    }
                }
            }
            return decryptedBytes;
        }

        //The next two methods are used to get the keys saved on the system to allow for decryption of the file.
    }
}

