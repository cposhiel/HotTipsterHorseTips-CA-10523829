using System;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using HorseTipRepository;
using HotTipster_Model_Layer.HotTipster_Horse_Tip_Model;
using ListEnquirerTests;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace MostPopularCourseTests
{
    [TestClass]
    public class MostPopularCourseTests
    {
        private List<HorseTip> dummyData;
        private IDummyHorseTipDataClass dummyHorseTipData;
        //Testing Method: ListEnquirer.MostPopularCourse();

        public MostPopularCourseTests()
        {
            dummyHorseTipData = new DummyHorseTipDataClass();
            dummyData = dummyHorseTipData.instantiateDummyHorseTipData();
        }

        [TestMethod]
        public void MostPopularCourseReturnsStringWithPunchestown()
        {
            //Arrange
            string course = "Punchestown";
            //Act
            string mostPopularCourse = ListEnquirer.MostPopularCourse(dummyData);
            //Assert
            Assert.IsTrue(mostPopularCourse.Contains(course));
        }
        

        [TestMethod]
        public void MostPopularCourseReturnsStringWithValueOf6()
        {
            {
                //Arrange
                string val = "6";
                //Act
                string mostPopularCourse = ListEnquirer.MostPopularCourse(dummyData);
                //Assert
                Assert.IsTrue(mostPopularCourse.Contains(val));
            }
        }
        [TestMethod]
        public void MostPopularCourseChangesToAscotWhen3BetsAreAdded()
        {
            //Arrange
            HorseTip testAdd1 = new HorseTip("Shake N' Bake", RaceCourses.Ascot, new DateTime(2017, 06, 21), 25.00m, false);
            HorseTip testAdd2 = new HorseTip("Holy Magoly", RaceCourses.Ascot, new DateTime(2017, 12, 02), 10.00m, false);
            HorseTip testAdd3 = new HorseTip("The Alamoney", RaceCourses.Ascot, new DateTime(2016, 03, 12), 50.00m, false);

            dummyData.Add(testAdd1);
            dummyData.Add(testAdd2);
            dummyData.Add(testAdd3);

            string course = "Ascot";
            //Act
            string mostPopularCourse = ListEnquirer.MostPopularCourse(dummyData);
            //Assert
            Assert.IsTrue(mostPopularCourse.Contains(course));

            //UnArrange
            dummyData.Remove(testAdd1);
            dummyData.Remove(testAdd2);
            dummyData.Remove(testAdd3);

        }
        [TestMethod]
        public void PrintNoDataWhenListIsNull()
        {
            //Arrange
            List<HorseTip> nullTips = null;
            string val = "No data to display.";
            //Act
            string testList = ListEnquirer.MostPopularCourse(nullTips);
            //Assert
            Assert.IsTrue(testList.Equals(val));
        }
        [TestMethod]
        public void PrintNoDataWhenListIsEmpty()
        {
            //Arrange
            string testList;
            List<HorseTip> emptyTips = new List<HorseTip>();
            //Act
            testList = ListEnquirer.MostPopularCourse(emptyTips);
            //Arrange           
            Assert.IsTrue(testList.Equals("No data to display."));

        }


    }
}
