using Xunit;
using PowerLibrary; // Reference the PowerLibrary project

namespace PowerLibrary.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void MyPow_WithTwoArguments_ShouldCalculateCorrectly()
        {
            // Arrange
            var powerCalculator = new PowerCalculator();
            double baseNum = 2;
            double exponent = 3;
            double expected = 8; // Because 2^3 = 8

            // Act
            double result = powerCalculator.MyPow(baseNum, exponent);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void MyPow_WithThreeArguments_ShouldCalculateCorrectly()
        {
            // Arrange
            var powerCalculator = new PowerCalculator();
            double baseNum = 2;
            double exponent = 3;
            double additionalExponent = 4;
            double expected = Math.Pow(Math.Pow(baseNum, exponent), additionalExponent); // Because (2^3)^4 is the expected

            // Act
            double result = powerCalculator.MyPow(baseNum, exponent, additionalExponent);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
