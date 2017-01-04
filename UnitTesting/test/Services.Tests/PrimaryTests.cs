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
    }
}
