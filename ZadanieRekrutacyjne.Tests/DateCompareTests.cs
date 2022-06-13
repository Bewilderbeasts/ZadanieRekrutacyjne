using NUnit.Framework;
using System;

namespace ZadanieRekrutacyjne.Tests
{
    [TestFixture]
    public class DateCompareTests
    {
        private DateCompare _dateCompare;

        [SetUp]
        public void Setup()
        {
            _dateCompare = new DateCompare();
        }
       

        [Test]
        public void Given_Valid_Dates_Method_Will_Succesfully_Check_If_Dates_Have_Same_Month_And_Year()
        {   //Arrange
            var firstDate = "11/11/2011";
            var secondDate = "30/11/2011";
            //Act
            var result = _dateCompare.CheckIfSameMonthAndYear(firstDate, secondDate);
            //Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void Given_Dates_With_Different_Months_And_Years_Method_Will_Fail_To_Check_If_Dates_Have_Same_Month_And_Year()
        {
            //Arrange
            var firstDate = "11/12/2011";
            var secondDate = "11/10/2020";
            //Act
            var result = _dateCompare.CheckIfSameMonthAndYear(firstDate, secondDate);
            //Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void Given_Valid_Dates_Method_Will_Succesfully_Check_If_Dates_Have_Same_Year()
        {  
            //Arrange
            var firstDate = "11/11/2011";
            var secondDate = "11/10/2011";
            //Act
            var result = _dateCompare.CheckIfSameYear(firstDate, secondDate);
            //Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void Given_Dates_With_Different_Years_Method_Will_Fail_To_Check_If_Dates_Have_Same_Year()
        {
            //Arrange
            var firstDate = "11/11/2011";
            var secondDate = "11/12/2020";
            //Act
            var result = _dateCompare.CheckIfSameYear(firstDate, secondDate);
            //Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void Given_Dates_Method_Will_Determine_Which_Is_Earlier()
        {
            // >0 if fDate is later than sDate
            // 0 if they are the same
            // <0 if fDate is earlier than sDate
            //Arrange
            DateTime firstDate = DateTime.UtcNow;
            DateTime secondDate = new DateTime(2000, 01, 01);
            var result = DateTime.Compare(firstDate, secondDate);
            //Act
            var isEarlier = _dateCompare.IsEarlier(result);
            //Assert
            Assert.IsTrue(isEarlier);
        }
 
    }
}