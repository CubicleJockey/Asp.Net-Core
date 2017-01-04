using Xunit;
using PrimaryService = Services.Primary;

namespace Services.Tests
{
    public class PrimaryServiceIsPrimeShould
    {
        private readonly Primary primary;

        public PrimaryServiceIsPrimeShould()
        {
            primary = new Primary();
        }

        [Fact]
        public void ReturnFalseGivenValueof1()
        {
            const int INPUT = 1;
            var result = primary.IsPrime(INPUT);
            Assert.False(result, $"{INPUT} should not be prime.");
        }

        [Theory] //<---Represents a suite of tests that execute the same code.
        [InlineData(-1)] //<--specifies value for the Theory Suite.
        [InlineData(0)] //<--specifies value for the Theory Suite.
        [InlineData(1)] //<--specifies value for the Theory Suite.
        public void ReturnFalseGivenValuesLessThan2(int value)
        {
            var result = primary.IsPrime(value);
            Assert.False(result, $"{value} should not be prime.");
        }
    }
}
