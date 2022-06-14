using NUnit.Framework;
using System;
using System.Globalization;

namespace ZadanieRekrutacyjne.Tests
{
    [TestFixture]
    public class DateFormatterTests
    {
        private DateFormatter _dateFormatter;

        [SetUp]
        public void Setup()
        {
            _dateFormatter = new DateFormatter();
        }

        //THIS TEST WAS WRITTEN JUST FOR THE SAKE OF CHECKING IF ChnDateReturner METHOD IS WORKING, WHEN GIVEN CHINESE DATE FORMAT (YYYY-MM-DD), SAME WOULD APPLY TO USA METHOD AND FORMAT
        //FOR THE SAKE OF TESTING ChnDateReturner ACCESS MODIFIER WAS CHANGED TO PUBLIC
        /* [Test]
         public void Given_Chn_Date_Formatting_Return_Date_With_Chn_Formatting()
         {   //Arrange
             string expectedResult = "2021/01/02 - 2022/02/04";
             DateTime firstDate = new DateTime(2021, 01, 02);
             DateTime secondDate = new DateTime(2022, 02, 04);
             bool isSameYear = false;
             bool isSameMonthAndYear = false;
             string separator = "/";
             //Act
             var result = DateFormatter.ChnDateReturner(isSameYear, isSameMonthAndYear, firstDate, secondDate, separator);

             //Assert
             Assert.AreEqual(expectedResult, result);
         } */

        [Test]
        public void Given_Culture_InfoWill_Return_String()
        {   //Arrange
            string expectedResult = "USA";
            CultureInfo cultureInfo = new CultureInfo("en-US");
            //Act
            var result = _dateFormatter.CultureInfoCheckerDate(cultureInfo);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }



    }
}