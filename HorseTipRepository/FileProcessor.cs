using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


/// <summary>
///This class is simply a file stream that uses binary formatter to serialise and deserialise the data.
///It doesn't offer any encryption.
/// </summary>
namespace HorseTipRepository
{
    public class FileProcessor : IFileProcessor
    {

        private static readonly string filePathName = "TipsData.txt";

        /// <summary>
        /// Writes HotTips in Binary to a File. Note: Exceptions are thrown.
        /// </summary>
        public void WriteToFile(List<HorseTip> horseBets)
        {
            using (FileStream fsBets = new FileStream(filePathName, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                try
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(fsBets, horseBets);
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
        /// <summary>
        /// Reads HotTips from binary from a file. Note: Exceptions are thrown.
        /// </summary>
        public List<HorseTip> ReadFromFile()
        {
            List<HorseTip> readData = new List<HorseTip>();
            using (FileStream fsBets = new FileStream(filePathName, FileMode.Open, FileAccess.Read))
            {
                try
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    readData = (List<HorseTip>)bf.Deserialize(fsBets);
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return readData;
        }

    }
}
