using HotTipster_Model_Layer.HotTipster_Horse_Tip_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace HorseTipRepository
{
    public static class ListEnquirer
    {

        private static string Format = "{0,20}";

        /// <summary>
        /// If race is won enter 'true'. Else; false.
        /// </summary>
        /// <param name="raceWon"></param>
        /// <returns>HorseTips</returns>
        private static List<HorseTip> GetWonOrLostRaces(List<HorseTip> hotTips, bool raceWon)
        {
            List<HorseTip> raceSplitList = new List<HorseTip>();

            var wonOrLost = from tips in hotTips
                            where tips.RaceWon == raceWon
                            select tips;

            foreach (var tip in wonOrLost)
            {
                raceSplitList.Add(tip);
            }
            return raceSplitList;
        }
        /// <summary>
        /// Querys the parameterised list of Horse Tips and returns a List<string></string> record of the the Total amounts bet each year.
        /// </summary>
        /// <param name="hotTips"></param>
        /// <returns></returns>
        public static List<string> GetAmountTotalsByYear(List<HorseTip> hotTips)
        {
            
            List<string> amountByYear = new List<string>();
            if (hotTips == null || hotTips.Count == 0)
            {
                amountByYear.Add("No data to display.");
            }
            else
            {
                //get total losses
                var amountLost = (from tip in GetWonOrLostRaces(hotTips, false)
                                  group tip by tip.DateOfRace.Year into yearTips
                                  select new 
                                  {
                                    year = yearTips.Key, 
                                      totalLost = yearTips.Sum(ht => ht.AmountWonOrLost) 
                                    }).Distinct();
                //get total wins
                var amountWon = (from tip in GetWonOrLostRaces(hotTips,true)
                                 group tip by tip.DateOfRace.Year into yearTips
                                 select new 
                                 { 
                                     year = yearTips.Key, 
                                     totalWon = yearTips.Sum(ht => ht.AmountWonOrLost) 
                                 }).Distinct();

                //left join the two to include all year wins where losses equal zero
                var totalYearWins = from tipWin in amountWon
                                    join tipLoss in amountLost on tipWin.year equals tipLoss.year into temp
                                    from tipLoss in temp.DefaultIfEmpty()

                                    select new
                                    {
                                        tipWin.year,
                                        Won = tipWin.totalWon,
                                        Lost = tipLoss == null ? 0 : tipLoss.totalLost,
                                    };
                //right join the two to include all year losses where wins equal zero
                var totalYearLosses = from tipLoss in amountLost
                                      join tipWin in amountWon on tipLoss.year equals tipWin.year into temp
                                      from tipWin in temp.DefaultIfEmpty()

                                      select new
                                      {
                                          tipLoss.year,
                                          Won = tipWin == null ? 0 : tipWin.totalWon,
                                          Lost = tipLoss.totalLost
                                      };

                //create full outer join by using union.
                var totalByYear = from totals in totalYearWins.Union(totalYearLosses)
                                  orderby totals.year
                                  select totals;



                //Report Heading
                amountByYear.Add(string.Format(Format, "Year:") + string.Format(Format, "Amount Won:")
                                        + string.Format(Format, "Amount Lost:") + Environment.NewLine);
                //Report Data
                foreach (var tip in totalByYear)
                {
                    amountByYear.Add(string.Format(Format, $"{tip.year}") + string.Format(Format, $"{tip.Won:C2}")
                                            + string.Format(Format, $"{tip.Lost:C2}") + Environment.NewLine);
                }
            }

            return amountByYear;
        }

       /// <summary>
       /// Querys the parameterised list of Horse Tips and returns a string record of the most popular course name and number of bets placed. 
       /// </summary>
       /// <param name="hotTips"></param>
       /// <returns>string</returns>
        public static string MostPopularCourse(List<HorseTip> hotTips)
        {
            
            if (hotTips == null || hotTips.Count == 0)
            {
                return "No data to display.";
            }
            else
            {
                var mostPopularCourse = (from tips in hotTips
                                         group tips by tips.Racecourse into racecourse
                                         orderby racecourse.Count() descending
                                         select new { Course = racecourse.Key, Count = racecourse.Count() }).Distinct().First();


                return $"The most popular course is {mostPopularCourse.Course} with {mostPopularCourse.Count} bets placed.";
            }
        }
        /// <summary>
        /// Querys the parameterised list of Horse Tips and returns a List<string>record of the tips in date order. 
        /// </summary>
        /// <param name="hotTips"></param>
        /// <returns>List<string></returns>
        public static List<string> TipsInDateOrder(List<HorseTip> hotTips)
        {
            List<string> dateOrderedList = new List<string>();
            if (hotTips == null || hotTips.Count == 0)
            {
                dateOrderedList.Add("No data to display.");
            }
            else
            {                
                var OrderedTips = from tip in hotTips
                                  orderby tip.DateOfRace
                                  select tip;

                foreach (var tip in OrderedTips)
                {
                    dateOrderedList.Add($"{tip.DateOfRace:dd/MM/yyyy} - ID: {tip.BetIdNo} - Horse: {tip.HorseName} " +
                                            $"- Course: {tip.Racecourse} - Amount: {tip.AmountWonOrLost}-{tip.Outcome}{Environment.NewLine}");
                }                
            }
            return dateOrderedList;
        }
        /// <summary>
        /// Querys the parameterised list of Horse Tips and returns a string record of the success rate of the bets. 
        /// </summary>
        /// <param name="hotTips"></param>
        /// <returns></returns>
        public static string GetSuccessRate(List<HorseTip> hotTips)
        {
            if (hotTips == null || hotTips.Count == 0)
            {
                return "No data to display.";
            }
            else
            {
                //get full count
                double raceCount = (from tips in hotTips
                                    select tips).Count();
                //get win count
                double winCount = (from tips in GetWonOrLostRaces(hotTips,true)
                                   select tips).Count();

                return $"HotTipster has won {winCount} out of {raceCount} bets.{Environment.NewLine}" +
                            $"Success rate = {Math.Round((winCount / raceCount) * 100)}%";
            }
        }
        /// <summary>
        /// Querys the parameterised list of Horse Tips and returns a string record of the highest amounts won and lost. 
        /// </summary>
        /// <param name="hotTips"></param>
        /// <returns></returns>
        public static string GetHighestAmountsWonAndLost(List<HorseTip> hotTips)
        {
            if (hotTips == null || hotTips.Count == 0)
            {
                return "No data to display.";
            }
            else
            {
                decimal highestWon = GetHighestAmountWon(hotTips);

                decimal highestLost = GetHighestAmountLost(hotTips);

                return $"Highest amount won: {highestWon:C2}.{Environment.NewLine}" +
                        $"Highest amount lost: {highestLost:C2}.";
            }

        }

        /// <summary>
        /// Returns a decimal of the highest amount won in the list of bets. Note: Null exception not handled here.
        /// </summary>
        /// <returns>decimal</returns>
        public static decimal GetHighestAmountWon(List<HorseTip> hotTips)
        {
            decimal highestWon = (from tips in GetWonOrLostRaces(hotTips, true)
                                  orderby tips.AmountWonOrLost descending
                                  select tips.AmountWonOrLost).First();
            return highestWon;
        }
        /// <summary>
        /// Returns a decimal of the lowest amount won in the list of bets. Note: Null exception not handled here.
        /// </summary>
        /// <returns>decimal</returns>
        public static decimal GetHighestAmountLost(List<HorseTip> hotTips)
        {
            decimal highestLost = (from tips in GetWonOrLostRaces(hotTips, false)
                                   orderby tips.AmountWonOrLost descending
                                   select tips.AmountWonOrLost).First();
            return highestLost;
        }

            
    }
}
