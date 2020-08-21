using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseTipRepository
{
    public class ByteProcessor : IByteProcessor
    {
        /// <summary>
        /// Writes a byte array to a file.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="key"></param>
        public void SaveBytesToFile(string path, byte[] key)
        {
            using (BinaryWriter bw = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate)))
            {
                try
                {
                    bw.Write(key);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
        /// <summary>
        /// Reads a Byte[] from a file.
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public byte[] ReadBytesFromFile(string path)
        {
            byte[] readData = new byte[0];
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            using (BinaryReader br = new BinaryReader(fs))
            {
                try
                {
                    int bufferlength = (int)fs.Length;
                    readData = br.ReadBytes(bufferlength);
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
            return readData;
        }
    }
}

