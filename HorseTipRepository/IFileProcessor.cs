using System.Collections.Generic;

namespace HorseTipRepository
{
    public interface IFileProcessor
    {
        void WriteToFile(List<HorseTip> horseBets);

        List<HorseTip> ReadFromFile();
    }
}