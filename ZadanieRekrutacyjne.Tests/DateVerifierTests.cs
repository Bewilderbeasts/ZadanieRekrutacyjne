using NUnit.Framework;

namespace ZadanieRekrutacyjne.Tests
{
    [TestFixture]
    public class DateVerifierTests
    {
        private DatetimeVerifier _datetimeVerifier;

        [SetUp]
        public void Setup()
        {
            _datetimeVerifier = new DatetimeVerifier();
        }

        [Test]
        public void Given_Valid_Date_Method_Will_Return_True()
        {
            //Arrange
            var date = "11/11/2011";
            //Act
            var result =_datetimeVerifier.IsDateTime(date);
            //Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void Given_Invalid_Date_Method_Will_Return_False()
        {
            //Arrange
            var date = "11/13/2011";
            //Act
            var result = _datetimeVerifier.IsDateTime(date);
            //Assert
            Assert.IsFalse(result);
        }

    }
}