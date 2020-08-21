using System;
using System.Collections.Generic;
using HorseTipRepository;
using ListEnquirerTests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TipsInDateOrderTests
{
    [TestClass]
    public class TipsInDateOrderTests
    {
        private List<HorseTip> dummyData;
        private IDummyHorseTipDataClass dummyHorseTipData;

        public TipsInDateOrderTests()
        {
            dummyHorseTipData = new DummyHorseTipDataClass();
            dummyData = dummyHorseTipData.instantiateDummyHorseTipData();
        }
        //Methods that test the query function designed to present Tips in Date Order.
        [TestMethod]
        public void TheFirst10CharachtersOfEachStringInListCanBeParsedIntoADate()
        {
            //Arrange 
            List<string> testList = new List<string>();
            //Act
            foreach (var item in ListEnquirer.TipsInDateOrder(dummyData))
            {
                string date = item.Substring(0, 10);
                testList.Add(date);
            }
            //Assert
            foreach (var item in testList)
            {
                Assert.IsTrue(DateTime.TryParse(item, out _));
            }
        }

        [TestMethod]
        public void PrintsNoDataWhenListIsNull()
        {
            //Arrange
            List<string> testList;
            List<HorseTip> nullTips = null;
            //Act
            testList = ListEnquirer.TipsInDateOrder(nullTips);
            //Arrange
            Assert.AreEqual(1, testList.Count);
            Assert.IsTrue(testList[0].Equals("No data to display."));

        }
        [TestMethod]
        public void PrintsNoDataWhenListIsEmpty()
        {
            //Arrange
            List<string> testList;
            List<HorseTip> emptyTips = new List<HorseTip>(); ;
            //Act
            testList = ListEnquirer.TipsInDateOrder(emptyTips);
            //Arrange
            Assert.AreEqual(1, testList.Count);
            Assert.IsTrue(testList[0].Equals("No data to display."));

        }
    }
}
