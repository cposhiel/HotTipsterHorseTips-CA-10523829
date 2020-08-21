using HorseTipRepository;
using HotTipster_Model_Layer.HotTipster_Horse_Tip_Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.HorseTipServices
{
    public enum error
    {
        none,
        name,
        course,
        date,
        amount
    }
    public class HorseTipDataValidator
    {

        public string ValidHorseName { get; }
        public RaceCourses ValidRacecourse { get; }
        public DateTime ValidDateOfRace { get; }
        public decimal ValidAmountWonOrLost { get; }
        public error Error { get; }
        //The error property is used to target and display the correct error type and request the a valid input. If the error type is none then the valid propeties
        //are used to construct a horseTip.
        /// <summary>
        /// A Validator object that takes in data to validate a horse bet and provides an error report upon construction.
        /// </summary>
        /// <param name="horseName"></param>
        /// <param name="raceCourse"></param>
        /// <param name="stringDate"></param>
        /// <param name="stringAmount"></param>
        /// <param name="raceWon"></param>
        public HorseTipDataValidator(string horseName, RaceCourses raceCourse, string stringDate, string stringAmount)
        {
            decimal amount = 0;
            error errorType = error.none;

            if (String.IsNullOrWhiteSpace(horseName))
            {
                errorType = error.name;
            }
            else
            {
                ValidHorseName = horseName;
                if ((ValidRacecourse = raceCourse) == (RaceCourses)(-1))
                {
                    errorType = error.course;
                }
                else
                {
                    if ((!DateTime.TryParseExact(stringDate, "dd/MM/yyyy",
                        CultureInfo.GetCultureInfo("ie-IE"), DateTimeStyles.None, out DateTime dateOfRace)) || dateOfRace > DateTime.Now)
                    {
                        errorType = error.date;
                        ValidDateOfRace = new DateTime();
                    }
                    else
                    {
                        ValidDateOfRace = dateOfRace;
                        if (Decimal.TryParse(stringAmount, out amount) && amount > 0)
                        {
                            ValidAmountWonOrLost = amount;
                        }
                        else
                        {
                            errorType = error.amount;
                        }
                    }
                }
            }

            Error = errorType;

        }
        public override string ToString()
        {
            return $"{Error}";
        }
        /// <summary>
        /// Checks list for HorseTip data.
        /// </summary>
        /// <param name="validatedList"></param>
        /// <returns>bool</returns>
        public static bool ValidateReadData(List<HorseTip> horseTipsList)
        {
            List<HorseTip> notNullHorseTipsList = HandleNullHorseTipList(horseTipsList);
            bool isValidated = false;
            if (notNullHorseTipsList.Any())
            {
                HotTips.horseTips = notNullHorseTipsList;
                isValidated = true;
            }
            return isValidated;
        }

        //This method is to provide an extra layer of security against a null instance of a list. 
        //Because the main list used in this app is static and is initiated with data it shouldn't be an issue 
        //but it is there as a precaution.
        public static List<HorseTip> HandleNullHorseTipList(List<HorseTip> horseTips)
        {
            try
            {
                //this is dud query to throw an exception if null.
                var validateHorseTips = from tips in horseTips
                                        select tips;
                return horseTips;
            }
            catch (Exception)
            {

                horseTips = new List<HorseTip>();
                return horseTips;
            }
        }
    }
}
