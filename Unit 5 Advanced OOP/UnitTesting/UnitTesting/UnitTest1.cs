using FakeProgram;
using Xunit;


namespace UnitTesting
{
    public class UnitTest1
    {
        //Facts are single tests
        [Fact]
        public void TwoNumbersAddedUpWillSum()
        {
            //arrange
            Arithmetic sut = new Arithmetic();

            //act
            int result = sut.Sum(2, 3);

            //assert
            Assert.Equal(5, result);
        }

        [Fact]
        public void TwoNumbersSubtractedWillDifference()
        {
            //Arrange
            Arithmetic sut = new Arithmetic();

            //act
            int result = sut.Sub(2,3);

            //assert
            Assert.Equal(-1, result);
        }

        //Theories are multiple tests in one
        [Theory]
        [InlineData(2,2,4)]
        [InlineData(10,3,30)]
        [InlineData(8,0,0)]
        [InlineData(-1,3, -3)]
        [InlineData(-2,-3,6)]
        public void TwoNumbersMultipliedWillTotal(int num1, int num2, int expected)
        {
            //Arrange
            Arithmetic sut = new Arithmetic();

            //Act
            int result = sut.Multi(num1, num2);

            //Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(6,3,2)]
        [InlineData(6, 1, 6)]
        [InlineData(6, -1, -6)]
        [InlineData(-6, -2, 3)]
        public void TwoNumbersDividedWillQuotient(int num1, int num2, int expected)
        {
            //Arrange
            Arithmetic sut = new Arithmetic();

            //Act
            int result = sut.Divi(num1, num2);

            //Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(32, "C", 0)]
        [InlineData(68, "C", 20)]
        [InlineData(100, "F", 212)]
        [InlineData(-40, "F", -40)]
        public void TempWillConvert(int temp, string target, double expected)
        {
            //Arrange
            Arithmetic sut = new Arithmetic();

            //Act
            double result = sut.tempConvert(temp, target);

            //Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("casual", 53, "Something Comfy | A Coat")]
        [InlineData("semi-formal", 53, "A polo | A Coat")]
        [InlineData("formal", 53, "A suit | A Coat")]
        [InlineData("casual", 60, "Something Comfy | A jacket")]
        [InlineData("semi-formal", 60, "A polo | A jacket")]
        [InlineData("formal", 60, "A suit | A jacket")]
        [InlineData("casual", 80, "Something Comfy | No Jacket")]
        [InlineData("semi-formal", 80, "A polo | No Jacket")]
        [InlineData("formal", 80, "A suit | No Jacket")]
        public void CorrectSuggestion(string eventType, int temp, string expected)
        {
            //Arrange
            Arithmetic sut = new Arithmetic();

            //Act
            string result = sut.Suggestion(eventType, temp);

            //Assert
            Assert.Equal(expected, result);
        }
        //"Something Comfy | A Coat"
        //result
        //result = "A polo | "
        //result += "No Jacket

    }
}