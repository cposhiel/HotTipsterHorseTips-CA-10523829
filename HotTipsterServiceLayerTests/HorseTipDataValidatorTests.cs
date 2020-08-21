using System;
using System.Collections.Generic;
using HorseTipRepository;
using HotTipster_Model_Layer.HotTipster_Horse_Tip_Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ServiceLayer.HorseTipServices;

namespace HorseTipDataValidatorTests
{
    [TestClass]
    public class HorseTipDataValidatorTests
    {
        [TestMethod]
        public void InvalidNameFieldReturnsEnumErrorName()
        {
            //Arrange
            HorseTipDataValidator validator;
            //Act
            validator = new HorseTipDataValidator("", RaceCourses.Aintree, "20/03/2020", "11.58");
            //Assert
            Assert.IsTrue(validator.Error == error.name);
        }
        [TestMethod]
        public void InvalidRaceCourseFieldReturnsEnumErrorRaceCourse()
        {
            //Arrange
            HorseTipDataValidator validator;
            //Act
            validator = new HorseTipDataValidator("Friday", (RaceCourses)(-1), "20/03/2020", "11.58");
            //Assert
            Assert.IsTrue(validator.Error == error.course);
        }
        [TestMethod]
        public void InvalidStringToDateFieldReturnsEnumErrorDate()
        {
            //Arrange
            HorseTipDataValidator validator;
            //Act
            validator = new HorseTipDataValidator("Friday", RaceCourses.Aintree, "203/2020", "11.58");
            //Assert
            Assert.IsTrue(validator.Error == error.date);
        }
        [TestMethod]
        public void InvalidStringToDecimalAmountFieldReturnsEnumErrorAmount()
        {
            //Arrange
            HorseTipDataValidator validator;
            //Act
            validator = new HorseTipDataValidator("Friday", RaceCourses.Aintree, "20/03/2020", "1xx.58");
            //Assert
            Assert.IsTrue(validator.Error == error.amount);
        }
        [TestMethod]
        public void ValidFieldsReturnEnumErrorNoneAndCanMakeAHorseTip()
        {
            //Arrange
            HorseTipDataValidator validator;
            HorseTip horseTip;
            //Act
            validator = new HorseTipDataValidator("Friday", RaceCourses.Aintree, "20/03/2020", "12.58");
            horseTip = new HorseTip(validator.ValidHorseName, validator.ValidRacecourse, validator.ValidDateOfRace, validator.ValidAmountWonOrLost, true);
            //Assert
            Assert.IsTrue(validator.Error == error.none);
            Assert.IsNotNull(horseTip);
        }
        [TestMethod]
        public void ValidatedHorseTipListIsTrueWhenNotNullOrEmpty()
        {
            //Arrange
            List<HorseTip> horseTips = new List<HorseTip> { new HorseTip("Friday", RaceCourses.Aintree, new DateTime(2017, 05, 12), 11.58m, true) };
            bool isValid;
            //Act
            isValid = HorseTipDataValidator.ValidateReadData(horseTips);
            //Arrange
            Assert.IsTrue(isValid);
        }
        [TestMethod]
        public void ValidatedHorseTipListIsFalseWhenNullOrEmpty()
        {
            //Arrange
            bool isValidNull;
            bool isValidEmpty;
            List<HorseTip> horseTips = null;
            List<HorseTip> horseTips1 = new List<HorseTip>(); ;
            //Act
            isValidNull = HorseTipDataValidator.ValidateReadData(horseTips);
            isValidEmpty = HorseTipDataValidator.ValidateReadData(horseTips1);
            //Arrange
            Assert.IsFalse(isValidNull);
            Assert.IsFalse(isValidEmpty);
        }
        [TestMethod]
        public void NullHorseTipsListReturnsEmptyInstead()
        {
            //Arrange
            List<HorseTip> horseTips = null;
            //Act
            horseTips = HorseTipDataValidator.HandleNullHorseTipList(horseTips);
            //Assert
            Assert.IsNotNull(horseTips);
            Assert.IsTrue(horseTips.Count == 0);
        }

    }
}
