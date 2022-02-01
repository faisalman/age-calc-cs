using System;
using Xunit;

namespace Faisalman.AgeCalc
{

    public class AgeCalcTest
    {
        [Theory]
        // example from readme
        [InlineData(1970, 8, 21, 
                    2014, 4, 30, 
                    43, 8, 9)]
        // issue #3
        [InlineData(2020, 11, 26, 
                    2020, 12, 25, 
                    0, 0, 29)]
        // issue #4
        [InlineData(2019, 1, 2, 
                    2020, 8, 31, 
                    1, 7, 29)]
        public void TestAge(int bdayYear, int bdayMonth, int bdayDay, 
                            int cdayYear, int cdayMonth, int cdayDay, 
                            int yearExpected, int monthExpected, int dayExpected)
        {
            DateTime bday = new DateTime(bdayYear, bdayMonth, bdayDay);
            DateTime cday = new DateTime(cdayYear, cdayMonth, cdayDay);
            Age ageActual = new Age(bday, cday);
            Assert.Equal(yearExpected, ageActual.Years);
            Assert.Equal(monthExpected, ageActual.Months);
            Assert.Equal(dayExpected, ageActual.Days);
        }
    }
}