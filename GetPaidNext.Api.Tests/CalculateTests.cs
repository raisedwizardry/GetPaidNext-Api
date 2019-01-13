using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace GetPaidNext.Api.Tests
{
    [TestFixture]
    public class CalculateTests
    {
        [Test]
        [TestCase(10)]
        [TestCase(6)]
        [TestCase(3)]
        [TestCase(1)]
        public void FutureDatesReturnEqualToSameDateBiweeklyDate(int date)
        {
            var systemUnderTest = new Calculate.GivenDate(DateTime.Now.AddDays(date).ToShortDateString());
            var given = systemUnderTest.BiweeklyNextPayDate();
            var expected = DateTime.Today.AddDays(date);
            Assert.That(DateTime.Parse(given), Is.EqualTo(expected));
        }

        [Test]
        [TestCase(10)]
        [TestCase(6)]
        [TestCase(3)]
        [TestCase(1)]
        public void FutureDatesReturnEqualToSameDateWeeklyDate(int date)
        {
            var systemUnderTest = new Calculate.GivenDate(DateTime.Now.AddDays(date).ToShortDateString());
            var given = systemUnderTest.WeeklyNextPayDate();
            var expected = DateTime.Today.AddDays(date);
            Assert.That(DateTime.Parse(given), Is.EqualTo(expected));
        }

        [Test]
        [TestCase(-10)]
        [TestCase(-6)]
        [TestCase(-3)]
        [TestCase(0)]
        public void PastOrCurrentDatesReturnEqualOrGreaterThanSameDateBiweeklyDate(int date)
        {
            var systemUnderTest = new Calculate.GivenDate(DateTime.Now.AddDays(date).ToShortDateString());
            var given = systemUnderTest.BiweeklyNextPayDate();
            Assert.That(DateTime.Parse(given), Is.GreaterThanOrEqualTo(DateTime.Now));
        }

        [Test]
        [TestCase(-10)]
        [TestCase(-6)]
        [TestCase(-3)]
        [TestCase(0)]
        public void PastOrCurrentDatesReturnEqualOrGreaterThanSameDateWeeklyDate(int date)
        {
            var systemUnderTest = new Calculate.GivenDate(DateTime.Now.AddDays(date).ToShortDateString());
            var given = systemUnderTest.WeeklyNextPayDate();
            Assert.That(DateTime.Parse(given), Is.GreaterThanOrEqualTo(DateTime.Now));
        }
    }
}
