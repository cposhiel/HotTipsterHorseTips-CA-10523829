using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace HorseTipRepository
{
    //Serialises/Deserialises the data to a MemoryStream
    class DataSerialiser : IDataSerialiser
    {
        /// <summary>
        /// Serialises a List<HorseTip> and returns them as a byte array.
        /// </summary>
        /// <param name="horseBets"></param>
        /// <returns>byte[]</returns>
        public  byte[] SerializeHorseTips(List<HorseTip> horseBets)
        {
            using (MemoryStream msBets = new MemoryStream())
            {
                byte[] serialisedBytes = null;
                try
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(msBets, horseBets);
                    serialisedBytes = msBets.ToArray();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                return serialisedBytes;
            }
        }

        /// <summary>
        /// Deserialises a byte array and constructs a List of HorseTips from the data.
        /// </summary>
        /// <param name="decryptedBytes"></param>
        /// <returns></returns>
        public List<HorseTip> DeserialiseBytes(byte[] decryptedBytes)
        {
            List<HorseTip> readData = new List<HorseTip>();

            using (MemoryStream msBets = new MemoryStream(decryptedBytes))
            {
                try
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    readData = (List<HorseTip>)bf.Deserialize(msBets);
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
