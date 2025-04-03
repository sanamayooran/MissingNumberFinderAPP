using Moq;
using MissingNumberFinderApp;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    [TestFixture]
    public class MissingNumberFinderServiceTest
    {
        [Test]
        public void MissingNumberFinderService_FindMissingNumber_ShouldReturnCorrectResult()
        {
            //arrange
            var mockMissingNumberFinder = new Mock<IMissingNumberFinder>();
            int[] numbers = { 0, 1, 3, 4, 5 };
            mockMissingNumberFinder.Setup(f => f.FindMissingNumber(numbers)).Returns(2);

            var missingNumberFinderService = new MissingNumberFinderService(mockMissingNumberFinder.Object);

            //act
            int result = missingNumberFinderService.FindMissingNumber(numbers);

            //assert
            Assert.That(result, Is.EqualTo(2));
        }
    }
}
