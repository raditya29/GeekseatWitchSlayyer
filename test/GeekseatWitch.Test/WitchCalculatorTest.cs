using Xunit;

namespace GeekseatWitch.Test
{
    public class WitchCalculatorTest
    {
        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, 1)]
        [InlineData(2, 1)]
        [InlineData(3, 2)]
        [InlineData(4, 3)]
        [InlineData(5, 5)]
        [InlineData(6, 8)]
        public void Fibonanci_Sequence_IsCorrect(int ordinal, int number)
        {
            // act
            var calculated = WitchCalculator.Fib(ordinal);

            // assert
            Assert.Equal(number, calculated);
        }

        [Theory]
        [InlineData(1, 1)]
        [InlineData(2, 2)]
        [InlineData(3, 4)]
        [InlineData(4, 7)]
        [InlineData(5, 12)]
        public void TargetCounts_PerYear_IsCorrect(int year, int counts)
        {
            // act
            var calculated = WitchCalculator.TargetCounts(year);

            // assert
            Assert.Equal(counts, calculated);
        }
    }
}
