using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotTipster_Model_Layer.HotTipster_Horse_Tip_Model
{
    //model is used to tell us that this is a data model
    /// <summary>
    ///  This is a model for each horse tip that HotTips has given.
    /// </summary>
    public class HorseTipModel : IHorseTipModel
    {

        public int BetIdNo { get;}
        public string HorseName { get; }
        public RaceCourses Racecourse { get; }
        public DateTime DateOfRace { get; }
        public decimal AmountWonOrLost { get; }
        public bool RaceWon { get;  }
        public string Outcome { get; }
    }
}
