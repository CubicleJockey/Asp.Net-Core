using Xunit;

namespace Utilities.Tests
{
    public class MathsMethods
    {
        [Theory]
        [InlineData(1L, 4L)]
        [InlineData(5L, 0L)]
        [InlineData(3L, 2L)]
        [InlineData(2L, 3L)]
        [InlineData(15L, -10L)]
        public void Return5(long lhs, long rhs)
        {
            var result = Maths.Add(lhs, rhs);
            Assert.Equal(5, result);
        }

        [Theory]
        [InlineData(24L, 12L)]
        [InlineData(50L, 38L)]
        [InlineData(12L, 0L)]
        public void Returns12(long lhs, long rhs)
        {
            var result = Maths.Subtract(lhs, rhs);
            Assert.Equal(12, result);
        }

        [Theory]
        [InlineData(32L, 1L)]
        [InlineData(2L, 16L)]
        [InlineData(16L, 2L)]
        public void Return32(long lhs, long rhs)
        {
            var result = Maths.Multiple(lhs, rhs);
            Assert.Equal(32, result);
        }

        [Theory]
        [InlineData(32L, 16L)]
        [InlineData(128L, 64L)]
        public void Return2(long dividend, long divisor)
        {
            var result = Maths.Divide(dividend, divisor);
            Assert.Equal(2, result);
        }
    }
}
