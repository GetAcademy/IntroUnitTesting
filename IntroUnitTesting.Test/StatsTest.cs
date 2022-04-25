using System;
using NUnit.Framework;

namespace IntroUnitTesting.Test
{
    public class StatsTest
    {
        [Test]
        public void TestWithTwoNumbers()
        {
            // arrange
            var stats = new Stats();

            // act
            stats.Add(3);
            stats.Add(4);

            // assert
            Assert.AreEqual(2, stats.Count);
            Assert.AreEqual(7, stats.Sum);
            Assert.AreEqual(4, stats.Max);
            Assert.AreEqual(3, stats.Min);
            Assert.AreEqual(3.5, stats.Mean);
        }

        [Test]
        public void TestWithThreeNumber()
        {
            // arrange
            var stats = new Stats();

            // act
            stats.Add(2);
            stats.Add(4);
            stats.Add(9);

            // assert
            Assert.AreEqual(3, stats.Count);
            Assert.AreEqual(15, stats.Sum);
            Assert.AreEqual(9, stats.Max);
            Assert.AreEqual(2, stats.Min);
            Assert.AreEqual(5, stats.Mean);
        }

        [Test]
        public void TestEmptyStats()
        {
            // arrange
            var stats = new Stats();

            // act

            // assert
            Assert.AreEqual(0, stats.Count);
            Assert.AreEqual(0, stats.Sum);
            Assert.IsNull(stats.Max);
            Assert.IsNull(stats.Min);
            Assert.AreEqual(float.NaN, stats.Mean);
            // Assert.Throws<DivideByZeroException>(()=> { var m = stats.Mean; });
        }
    }
}