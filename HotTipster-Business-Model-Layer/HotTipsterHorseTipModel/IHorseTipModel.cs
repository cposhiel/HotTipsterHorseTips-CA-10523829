using System;

namespace HotTipster_Model_Layer.HotTipster_Horse_Tip_Model
{
    public interface IHorseTipModel
    {
        int BetIdNo { get;}
        string HorseName { get; }
        RaceCourses Racecourse { get;}
        DateTime DateOfRace { get;  }
        decimal AmountWonOrLost { get; }
        bool RaceWon { get; }
        string Outcome { get; }
    }
}