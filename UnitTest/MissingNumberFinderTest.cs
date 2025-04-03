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
    public class MissingNumberFinderTest
    {
        [Test]
        public void MissingNumberFinder_FindMissingNumber_ShouldReturnCorrectResult()
        {
            //arrange 
            MissingNumberFinder missingNumberFinder = new MissingNumberFinder();
            int[] numbers = { 0, 1, 3, 4, 5 };

            //act
            int result = missingNumberFinder.FindMissingNumber(numbers);

            //assert
            Assert.That(result, Is.EqualTo(2));
        }
    }
}
