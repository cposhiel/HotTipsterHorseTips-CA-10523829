using System;
using System.Collections.Generic;
using HorseTipRepository;
using HotTipster_Model_Layer.HotTipster_Horse_Tip_Model;
using ListEnquirerTests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GetHighestAmountsWonAndLostTests
{

    [TestClass]
    public class GetHighestAmountsWonAndLostTests
    {
        private List<HorseTip> dummyData;
        private IDummyHorseTipDataClass dummyHorseTipData;
        
        public GetHighestAmountsWonAndLostTests()
        {
            dummyHorseTipData = new DummyHorseTipDataClass();
            dummyData = dummyHorseTipData.instantiateDummyHorseTipData();            
        }

        //Testing Method: ListEnquirer.GetHighestAmountWon();
        [TestMethod]
        public void HighestAmountWonEquals525_74()
        {
            //Arrange
            decimal highestAmount;
            decimal expected = 525.74m;

            //Act
            highestAmount = ListEnquirer.GetHighestAmountWon(dummyData);

            //Assert
            Assert.AreEqual(expected,highestAmount);
        }
        [TestMethod]
        public void AddingA1000WinningBetChangesHighestAmountWonto1000()
        {

            //Arrange
            
            decimal highestAmount;
            decimal expected = 1000m;
            HorseTip testAdd1 = new HorseTip("Holy Magoly", RaceCourses.Ayr, new DateTime(2016, 12, 02), 1000.00m, true);
            dummyData.Add(testAdd1);

            //Act
            highestAmount = ListEnquirer.GetHighestAmountWon(dummyData);

            //Assert
            Assert.AreEqual(expected, highestAmount);

            //Revert 
            dummyData.Remove(testAdd1);
        }
        [TestMethod]
        public void HighestAmountLostEquals50()
        {
            //Arrange
            decimal highestAmount;
            decimal expected = 50m;

            //Act
            highestAmount = ListEnquirer.GetHighestAmountLost(dummyData);

            //Assert
            Assert.AreEqual(expected, highestAmount);
        }
        [TestMethod]
        public void AddingA1000LostBetChangesHighestAmountLostTo1000()
        {

            //Arrange

            decimal highestAmount;
            decimal expected = 1000m;
            HorseTip testAdd1 = new HorseTip("Holy Magoly", RaceCourses.Ayr, new DateTime(2016, 12, 02), 1000.00m, false);
            dummyData.Add(testAdd1);

            //Act
            highestAmount = ListEnquirer.GetHighestAmountLost(dummyData);

            //Assert
            Assert.AreEqual(expected, highestAmount);

            //Revert 
            dummyData.Remove(testAdd1);
        }
        [TestMethod]
        public void GetHighestAmountsWonAndLostDisplaysARecordOfTheHighestAmountsWon525_74AndLost50()
        {
            //Arrange
            decimal expectedHighestWon = 525.74m;
            decimal expectedHighestLost = 50;

            //Act
            string highestWonAndLost = ListEnquirer.GetHighestAmountsWonAndLost(dummyData);

            //Assert
            Assert.IsTrue(highestWonAndLost.Equals(GetRecordOfHighestWonAndLostStringFormat(expectedHighestWon, expectedHighestLost)));
        }
        [TestMethod]
        public void PrintNoDataWhenListIsNull()
        {
            //Arrange
            string dummyData;
            List<HorseTip> nullTips = null;
            //Act
            dummyData = ListEnquirer.GetHighestAmountsWonAndLost(nullTips);
            //Arrange           
            Assert.IsTrue(dummyData.Equals("No data to display."));

        }
        [TestMethod]
        public void PrintNoDataWhenListIsEmpty()
        {
            //Arrange
            string dummyData;
            List<HorseTip> emptyTips = new List<HorseTip>();
            //Act
            dummyData = ListEnquirer.GetHighestAmountsWonAndLost(emptyTips);
            //Arrange           
            Assert.IsTrue(dummyData.Equals("No data to display."));
        }

        /// <summary>
        /// A method that reproduces the highest amount won and lost string format for testing.
        /// </summary>
        /// <param name="highestWon"></param>
        /// <param name="highestLost"></param>
        /// <returns></returns>
        private string GetRecordOfHighestWonAndLostStringFormat(decimal highestWon, decimal highestLost)
        {
            return $"Highest amount won: {highestWon:C2}.{Environment.NewLine}" +
                            $"Highest amount lost: {highestLost:C2}.";
        }
    }
}
