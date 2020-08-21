using System.Collections.Generic;

namespace HorseTipRepository
{
    internal interface IDataSerialiser
    {
        byte[] SerializeHorseTips(List<HorseTip> horseBets);
        List<HorseTip> DeserialiseBytes(byte[] decryptedBytes);
    }
}