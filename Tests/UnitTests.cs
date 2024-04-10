using System;
using NUnit.Framework;

namespace GameFrameX.Scene.Tests
{
    internal class UnitTests
    {
        private DateTime dateTime, dateTime1;

        [SetUp]
        public void Setup()
        {
            dateTime = DateTime.Now;
            dateTime1 = DateTime.Now.AddHours(1);
        }

        // Here is an example of a unit test for the IsUnixSameDay method
        [Test]
        public void TestIsUnixSameDay()
        {
            // Arrange
            // long timestamp1 = 1617842400; // April 7, 2021 12:00:00 AM UTC
            // long timestamp2 = 1617896400; // April 7, 2021 12:00:00 PM UTC

            // Act
        }


        [Test]
        public void Test1()
        {
            Assert.That(dateTime1.Year, Is.EqualTo(dateTime.Year));
            Assert.That(dateTime1.Month, Is.EqualTo(dateTime.Month));
            Assert.That(dateTime1.Day, Is.EqualTo(dateTime.Day));
        }
    }
}