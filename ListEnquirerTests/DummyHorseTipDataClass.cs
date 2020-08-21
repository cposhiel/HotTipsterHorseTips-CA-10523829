using HorseTipRepository;
using HotTipster_Model_Layer.HotTipster_Horse_Tip_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListEnquirerTests
{
    public class DummyHorseTipDataClass : IDummyHorseTipDataClass
    {
        public List<HorseTip> instantiateDummyHorseTipData()
        {
            return new List<HorseTip>{
                new HorseTip("Friday", RaceCourses.Aintree, new DateTime(2017, 05, 12), 11.58m, true),
                new HorseTip("She's The Fastest", RaceCourses.Punchestown, new DateTime(2016, 12, 22), 122.52m, true),
                new HorseTip("Lordy Lord", RaceCourses.Sandown, new DateTime(2016, 11, 17), 20.00m, false),
                new HorseTip("Horsey McHorseface", RaceCourses.Ayr, new DateTime(2016, 11, 03), 25.00m, false),
                new HorseTip("Shergar", RaceCourses.Fairyhouse, new DateTime(2016, 12, 02), 65.75m, true),
                new HorseTip("Janey Mack", RaceCourses.Ayr, new DateTime(2017, 03, 11), 12.05m, true),
                new HorseTip("Holy Magoly", RaceCourses.Doncaster, new DateTime(2017, 12, 02), 10.00m, false),
                new HorseTip("The Alamoney", RaceCourses.Towcester, new DateTime(2016, 03, 12), 50.00m, false),
                new HorseTip("Last Place", RaceCourses.Goodwood, new DateTime(2017, 10, 07), 525.74m, true),
                new HorseTip("I Couldn't Tell Ya", RaceCourses.Kelso, new DateTime(2016, 09, 13), 43.21m, true),
                new HorseTip("Santa's Little Helper", RaceCourses.Punchestown, new DateTime(2017, 07, 05), 35.00m, false),
                new HorseTip("Could It Be?", RaceCourses.Ascot, new DateTime(2016, 02, 04), 23.65m, true),
                new HorseTip("Lord Byron", RaceCourses.Kelso, new DateTime(2017, 08, 02), 30.00m, false),
                new HorseTip("Seabiscuit", RaceCourses.Towcester, new DateTime(2017, 05, 01), 104.33m, true),
                new HorseTip("Shake N' Bake", RaceCourses.Ascot, new DateTime(2017, 06, 21), 25.00m, false),
                new HorseTip("For What It's Worth", RaceCourses.Bangor, new DateTime(2016, 12, 22), 30.00m, false),
                new HorseTip("Daydream Believer", RaceCourses.Ayr, new DateTime(2017, 05, 22), 11.50m, true),
                new HorseTip("Living On A Prayer", RaceCourses.Ascot, new DateTime(2017, 06, 23), 30.00m, false),
                new HorseTip("The Mane Man", RaceCourses.Ascot, new DateTime(2017, 06, 23), 374.27m, true),
                new HorseTip("Another One Bites The Dust", RaceCourses.Goodwood, new DateTime(2016, 10, 05), 34.12m, true),
                new HorseTip("Buckowski", RaceCourses.Dundalk, new DateTime(2016, 11, 09), 20.00m, false),
                new HorseTip("Tempest", RaceCourses.Haydock, new DateTime(2016, 11, 12), 87.00m, true),
                new HorseTip("Vonnegut", RaceCourses.Perth, new DateTime(2017, 01, 20), 15.00m, false),
                new HorseTip("That's The Spirit", RaceCourses.York, new DateTime(2017, 11, 11), 101.25m, true),
                new HorseTip("Take A Bow", RaceCourses.Punchestown, new DateTime(2016, 12, 22), 11.50m, true),
                new HorseTip("Ah G'wan", RaceCourses.Chester, new DateTime(2016, 08, 14), 10.00m, false),
                new HorseTip("Your Blue Jumper", RaceCourses.Kelso, new DateTime(2016, 09, 18), 10.00m, false),
                new HorseTip("Shadowfax", RaceCourses.Kilbeggan, new DateTime(2017, 03, 03), 20.00m, false),
                new HorseTip("Lugh", RaceCourses.Fairyhouse, new DateTime(2017, 03, 11), 55.50m, true),
                new HorseTip("FingersMcginty", RaceCourses.Punchestown, new DateTime(2016, 11, 15), 10.00m, false),
                new HorseTip("Be Grand", RaceCourses.Towcester, new DateTime(2016, 05, 08), 16.55m, true),
                new HorseTip("Don't Drink Dettol", RaceCourses.Punchestown, new DateTime(2016, 05, 23), 13.71m, true),
                new HorseTip("Giddyup", RaceCourses.Cork, new DateTime(2016, 11, 30), 20.00m, false),
                new HorseTip("Take A Bow", RaceCourses.Punchestown, new DateTime(2016, 04, 25), 13.45m, true),
                new HorseTip("The Gift Horse", RaceCourses.Bangor, new DateTime(2016, 01, 23), 10.00m, false),
                new HorseTip("Marvolo", RaceCourses.Sandown, new DateTime(2017, 08, 07), 25.00m, false)};
        }
    }
}
