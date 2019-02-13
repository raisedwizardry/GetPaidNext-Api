using System;
using Xunit;
using GetPaidNext.Api.Calculate;

namespace GetPaidNext.Api.MoreTests
{
    public class MoreCalculateTests
    {
        [Fact]
        public void ShouldParseStaticDate()
        {
            Assert.Equal(DateTime.Parse("2000-1-1"), new DateTime(2000, 1, 1));
        }

        [Theory]
        [InlineData(10)]
        [InlineData(6)]
        [InlineData(3)]
        [InlineData(1)]
        public void MonthlyFutureDateShouldBeSameAsCalculated(int date)
        {
            var systemUnderTest = new Monthly(DateTime.Now.AddDays(date).ToShortDateString());
            var given = systemUnderTest.NextPayDate();
            var expected = DateTime.Today.AddDays(date);
            Assert.Equal(DateTime.Parse(given), expected);
        }

        [Theory]
        [InlineData(-10)]
        [InlineData(-6)]
        [InlineData(-3)]
        [InlineData(-1)]
        [InlineData(0)]
        public void MonthlyPastDatesShouldBeEqualOrGreaterThanCalculated(int date)
        {
            var systemUnderTest = new Monthly(DateTime.Now.AddDays(date).ToShortDateString());
            var given = systemUnderTest.NextPayDate();
            Assert.True(DateTime.Parse(given) >= DateTime.Now);
        }

        [Theory]
        [InlineData(10)]
        [InlineData(6)]
        [InlineData(3)]
        [InlineData(1)]
        public void BimonthlyFutureDateShouldBeSameAsCalculated(int date)
        {
            var systemUnderTest = new Bimonthly(DateTime.Now.AddDays(date).ToShortDateString());
            var given = systemUnderTest.NextPayDate();
            var expected = DateTime.Today.AddDays(date);
            Assert.Equal(DateTime.Parse(given), expected);
        }

        [Theory]
        [InlineData(-10)]
        [InlineData(-6)]
        [InlineData(-3)]
        [InlineData(-1)]
        [InlineData(0)]
        public void BimonthlyPastDatesShouldBeEqualOrGreaterThanCalculated(int date)
        {
            var systemUnderTest = new Bimonthly(DateTime.Now.AddDays(date).ToShortDateString());
            var given = systemUnderTest.NextPayDate();
            Assert.True(DateTime.Parse(given) >= DateTime.Now);
        }
    }
}
