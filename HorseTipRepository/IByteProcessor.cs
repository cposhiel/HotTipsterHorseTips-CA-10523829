namespace HorseTipRepository
{
    public interface IByteProcessor
    {
        byte[] ReadBytesFromFile(string path);
        void SaveBytesToFile(string path, byte[] key);
    }
}