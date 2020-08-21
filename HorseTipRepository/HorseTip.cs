using HotTipster_Model_Layer.HotTipster_Horse_Tip_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HorseTipRepository
{
    [Serializable()]
    public class HorseTip : IHorseTipModel, IComparable<HorseTip>, ISerializable
    {
        private static int idIncrement = 100000;
        public int BetIdNo { get; }
        public string HorseName { get; }
        public RaceCourses Racecourse { get; }
        public DateTime DateOfRace { get; }
        public decimal AmountWonOrLost { get;}
        public bool RaceWon { get; }
        public string Outcome { get;}

        
        public HorseTip(string horseName, RaceCourses racecourse, DateTime dateOfRace, decimal amountWonOrLost, bool raceWon)
        {
            BetIdNo = idIncrement++;
            HorseName = horseName;
            Racecourse = racecourse;
            DateOfRace = dateOfRace;
            AmountWonOrLost = amountWonOrLost;
            RaceWon = raceWon;

            Outcome = RaceWon ? "Won" : "Lost";
        }
        //Used to list the horse bets.
        public override string ToString()
        {
            return $"BET: {BetIdNo} - {HorseName.ToUpper()} - {Racecourse.ToString().ToUpper()} - ({DateOfRace.ToString("yyyy/MM/dd")}) - {Outcome.ToUpper()} - {AmountWonOrLost:C2}{Environment.NewLine}";
        }
        //Used on creation of the horse bets.
        public string ToStringInDetail()
        {
            return $"Bet ID: {BetIdNo + Environment.NewLine}" +
                        $"Horse: {HorseName}{Environment.NewLine}" +
                                $"Race Course: {Racecourse}{Environment.NewLine}" +
                                    $"Date of Race: ({DateOfRace.ToString("yyyy/MM/dd")}){Environment.NewLine}" +
                                        $"Race Outcome: {Outcome}{Environment.NewLine}" +
                                            $"Amount {Outcome}: {AmountWonOrLost:C2}";
        }
        //this method provides the meta data to let binary formatter know what object to build on desrialisation. 
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Bet Id No", BetIdNo);
            info.AddValue("Horse Name", HorseName);
            info.AddValue("Race Course", Racecourse);
            info.AddValue("Date Of Race", DateOfRace);
            info.AddValue("Amount", AmountWonOrLost);
            info.AddValue("Race Won", RaceWon);
        }

        public int CompareTo(HorseTip other)
        {
            return other == null ||
            DateOfRace > other.DateOfRace ? 1 :
                DateOfRace < other.DateOfRace ? -1 : 0;
        }
        //The underlying method uses reflection to deserialize the HorseTip objects contained in a file.
        /// <summary>
        /// Constructor to rebuild HorseTip from Serialized Data.
        /// </summary>
        /// <param name="info"></param>
        /// <param name="context"></param>
        public HorseTip(SerializationInfo info, StreamingContext context)
        {
            BetIdNo = (int)info.GetValue("Bet Id No", typeof(int));
            HorseName = (string)info.GetValue("Horse Name", typeof(string));
            Racecourse = (RaceCourses)info.GetValue("Race Course", typeof(RaceCourses));
            DateOfRace = (DateTime)info.GetValue("Date Of Race", typeof(DateTime));
            AmountWonOrLost = (decimal)info.GetValue("Amount", typeof(decimal));
            RaceWon = (bool)info.GetValue("Race Won", typeof(bool)); ;

            Outcome = RaceWon ? "Won" : "Lost";
        }
    }
}
