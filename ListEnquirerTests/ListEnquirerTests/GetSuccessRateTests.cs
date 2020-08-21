using System;
using System.Collections.Generic;
using HorseTipRepository;
using HotTipster_Model_Layer.HotTipster_Horse_Tip_Model;
using ListEnquirerTests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GetSuccessRateTests
{
    [TestClass]
    public class GetSuccessRateTests
    {
        private List<HorseTip> dummyData;
        private IDummyHorseTipDataClass dummyHorseTipData;

        //Testing Method: ListEnquirer.GetSuccessRate();
        public GetSuccessRateTests()
        {
            dummyHorseTipData = new DummyHorseTipDataClass();
            dummyData = dummyHorseTipData.instantiateDummyHorseTipData();
        }
        [TestMethod]
        public void EighteenWinsOutOf36TipsEqualsASuccessRateOf50()
        {
            //Arrange
            string expected = GetSuccessRateReportString(18, 36, 50);
            //Act
            string successRate = ListEnquirer.GetSuccessRate(dummyData);
            //Assert
            Assert.IsTrue(successRate.Equals(expected));
        }
        [TestMethod]
        public void Adding5WinsChangesPercentageTo56()
        {

            //Arrange
            HorseTip testAdd1 = new HorseTip("The Alamoney", RaceCourses.Ascot, new DateTime(2016, 03, 12), 1000.00m, true);
            HorseTip testAdd2 = new HorseTip("Holy Magoly", RaceCourses.Ayr, new DateTime(2016, 12, 02), 1000.00m, true);
            HorseTip testAdd3 = new HorseTip("Holy Magoly", RaceCourses.Ayr, new DateTime(2016, 12, 02), 1000.00m, true);
            HorseTip testAdd4 = new HorseTip("Holy Magoly", RaceCourses.Ayr, new DateTime(2016, 12, 02), 1000.00m, true);
            HorseTip testAdd5 = new HorseTip("Holy Magoly", RaceCourses.Ayr, new DateTime(2016, 12, 02), 1000.00m, true);

            dummyData.Add(testAdd1);
            dummyData.Add(testAdd2);
            dummyData.Add(testAdd3);
            dummyData.Add(testAdd4);
            dummyData.Add(testAdd5);

            string expected = GetSuccessRateReportString(23, 41, 56);


            //Act
            string successRate = ListEnquirer.GetSuccessRate(dummyData);
            //Assert
            Assert.IsTrue(successRate.Equals(expected));

            //Revert
            dummyData.Remove(testAdd1);
            dummyData.Remove(testAdd2);
            dummyData.Remove(testAdd3);
            dummyData.Remove(testAdd4);
            dummyData.Remove(testAdd5);
        }
        [TestMethod]
        public void Adding5lossesChangesPercentageTo45()
        {

            //Arrange
            HorseTip testAdd1 = new HorseTip("The Alamoney", RaceCourses.Ascot, new DateTime(2016, 03, 12), 1000.00m, false);
            HorseTip testAdd2 = new HorseTip("Holy Magoly", RaceCourses.Ayr, new DateTime(2016, 12, 02), 1000.00m, false);
            HorseTip testAdd3 = new HorseTip("Holy Magoly", RaceCourses.Ayr, new DateTime(2016, 12, 02), 1000.00m, false);
            HorseTip testAdd4 = new HorseTip("Holy Magoly", RaceCourses.Ayr, new DateTime(2016, 12, 02), 1000.00m, false);
            HorseTip testAdd5 = new HorseTip("Holy Magoly", RaceCourses.Ayr, new DateTime(2016, 12, 02), 1000.00m, false);

            dummyData.Add(testAdd1);
            dummyData.Add(testAdd2);
            dummyData.Add(testAdd3);
            dummyData.Add(testAdd4);
            dummyData.Add(testAdd5);

            string expected = GetSuccessRateReportString(18, 41, 44);


            //Act
            string successRate = ListEnquirer.GetSuccessRate(dummyData);
            //Assert
            Assert.IsTrue(successRate.Equals(expected));

            //Revert
            dummyData.Remove(testAdd1);
            dummyData.Remove(testAdd2);
            dummyData.Remove(testAdd3);
            dummyData.Remove(testAdd4);
            dummyData.Remove(testAdd5);
        }
        [TestMethod]
        public void PrintsNoDataWhenListIsNull()
        {
            //Arrange
            string testList;
            List<HorseTip> nullTips = null;
            //Act
            testList = ListEnquirer.GetSuccessRate(nullTips);
            //Arrange
            Assert.IsTrue(testList.Equals("No data to display."));
        }
        [TestMethod]
        public void PrintNoDataWhenListIsEmpty()
        {
            //Arrange
            string testList;
            List<HorseTip> emptyTips = new List<HorseTip>();
            //Act
            testList = ListEnquirer.GetSuccessRate(emptyTips);
            //Arrange           
            Assert.IsTrue(testList.Equals("No data to display."));
        }

        private string GetSuccessRateReportString(int winCount, int raceCount, int percentage)
        {
        return $"HotTipster has won {winCount} out of {raceCount} bets.{Environment.NewLine}" +
                            $"Success rate = {percentage}%";
        }
    }
}
