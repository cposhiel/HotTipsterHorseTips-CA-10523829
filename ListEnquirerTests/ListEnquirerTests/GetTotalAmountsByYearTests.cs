using System;
using System.Collections.Generic;
using HorseTipRepository;
using HotTipster_Model_Layer.HotTipster_Horse_Tip_Model;
using ListEnquirerTests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GetTotalAmountsByYearTests
{
    [TestClass]
    public class GetTotalAmountsByYearTests
    {
        private List<HorseTip> dummyData;
        private IDummyHorseTipDataClass dummyHorseTipData;
        //Testing Method: ListEnquirer.GetAmountTotalsByYear();

        public GetTotalAmountsByYearTests()
        {
            dummyHorseTipData = new DummyHorseTipDataClass();
            dummyData = dummyHorseTipData.instantiateDummyHorseTipData();
        }

        [TestMethod]
        public void AmountTotalsByYearHaveOnlyTheYears2016And2017AndOnlyOnceEach()
        {
            //Arrange
            List<string> totalsByYear;
            //Act
            totalsByYear = ListEnquirer.GetAmountTotalsByYear(dummyData);
            //Assert
            Assert.IsTrue(totalsByYear[1].Contains("2016"));
            Assert.IsTrue(totalsByYear[2].Contains("2017"));
            //Method features a heading as its first element. so 1 + number of years (2) equals 3.
            Assert.AreEqual(3, totalsByYear.Count);
        }

        [TestMethod]
        public void TotalAmountsWonEqual_431_46_And_1196_22_WhileLostEqual_205_190_For2016And2107Respectively()
        {

            //Arrange
            string format = "{0, 20}";
            List<string> testList;

            //Act
            testList = ListEnquirer.GetAmountTotalsByYear(dummyData);

            //Assert
            //This is the heading element of the report generated.
            Assert.IsTrue(testList[0].Equals(string.Format(format, "Year:") + string.Format(format, "Amount Won:")
                                                    + string.Format(format, "Amount Lost:") + Environment.NewLine));

            //These are the values each year
            Assert.IsTrue(testList[1].Equals(GetRecordOfAmountsByYearStringFormat(2016, 431.46m, 205m)));
            Assert.IsTrue(testList[2].Equals(GetRecordOfAmountsByYearStringFormat(2017, 1196.22m, 190m)));

            //Method features a heading as its first element. so 1 + number of years (2) equals 3.
            Assert.AreEqual(3, testList.Count);
        }

        [TestMethod]
        public void AddingBetsWithA1000changesTotalsAmountsFor2016By1000()
        {
            //Arrange

            List<string> testList;

            HorseTip testAdd1 = new HorseTip("The Alamoney", RaceCourses.Ascot, new DateTime(2016, 03, 12), 1000.00m, false);
            HorseTip testAdd2 = new HorseTip("Holy Magoly", RaceCourses.Ayr, new DateTime(2016, 12, 02), 1000.00m, true);

            dummyData.Add(testAdd1);
            dummyData.Add(testAdd2);

            //Act
            testList = ListEnquirer.GetAmountTotalsByYear(dummyData);

            //Assert
            Assert.IsTrue(testList[1].Equals(GetRecordOfAmountsByYearStringFormat(2016, 1431.46m, 1205m)));


            //Unarrange
            dummyData.Remove(testAdd1);
            dummyData.Remove(testAdd2);
        }

        [TestMethod]
        public void AddingANewYearWithOnlyAWinningBetShowsLossesAt0()
        {
            //Arrange

            List<string> testList; 

            HorseTip testAdd1 = new HorseTip("The Alamoney", RaceCourses.Ascot, new DateTime(2019, 03, 12), 50.00m, true);
            dummyData.Add(testAdd1);

            //Act
            testList = ListEnquirer.GetAmountTotalsByYear(dummyData);
            //Assert
            Assert.IsTrue(testList[3].Equals(GetRecordOfAmountsByYearStringFormat(2019, 50m, 0m)));
            //Unarrange
            dummyData.Remove(testAdd1);
        }

        [TestMethod]
        public void AddingANewYearWithOnlyALosingBetShowsWinningsAt0()
        {
            //Arrange            
            List<string> totalsByYear = new List<string>();

            HorseTip testAdd1 = new HorseTip("The Alamoney", RaceCourses.Ascot, new DateTime(2019, 03, 12), 50.00m, false);
            dummyData.Add(testAdd1);

            //Act
            totalsByYear = ListEnquirer.GetAmountTotalsByYear(dummyData);
            //Assert
            Assert.IsTrue(totalsByYear[3].Equals(GetRecordOfAmountsByYearStringFormat(2019, 0.00m, 50m)));
            //Unarrange
            dummyData.Remove(testAdd1);
        }

        
        [TestMethod]
        public void PrintNoDataWhenListIsNull()
        {
            //Arrange
            List<string> testList;
            List<HorseTip> nullTips = null;
            //Act
            testList = ListEnquirer.GetAmountTotalsByYear(nullTips);
            //Arrange
            Assert.AreEqual(1, testList.Count);
            Assert.IsTrue(testList[0].Equals("No data to display."));

        }

        [TestMethod]
        public void PrintNoDataWhenListIsEmpty()
        {
            //Arrange
            List<string> testList;
            List<HorseTip> emptyTips = new List<HorseTip>();
            //Act
            testList = ListEnquirer.GetAmountTotalsByYear(emptyTips);
            //Arrange
            Assert.AreEqual(1, testList.Count);
            Assert.IsTrue(testList[0].Equals("No data to display."));

        }

        private string  GetRecordOfAmountsByYearStringFormat(int date, decimal winnings, decimal losses)
        {
            string format = "{0, 20}";
            return string.Format(format, $"{date}") + string.Format(format, $"{winnings:C2}")
                    + string.Format(format, $"{losses:C2}") + Environment.NewLine;
        }
    }
}
