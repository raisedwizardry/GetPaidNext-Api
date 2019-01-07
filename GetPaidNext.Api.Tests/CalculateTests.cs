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
        public void PastDateReturnsEqualOrGreaterThanNowBiweeklyDate()
        {
            var systemUnderTest = new Calculate.Biweekly();
            var given = systemUnderTest.NextPayDate(DateTime.Now.AddDays(-3).ToShortDateString());
            Assert.That(DateTime.Parse(given), Is.GreaterThanOrEqualTo(DateTime.Now));
        }
    }
}
