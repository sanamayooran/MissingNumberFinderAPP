using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissingNumberFinderApp
{
    public class MissingNumberFinder : IMissingNumberFinder
    {
        public int FindMissingNumber(int[] numbers)
        {
            int n = numbers.Length;
            //Logic for missing number in sequence of n
            int expectedSum = (n * (n + 1)) / 2; // Sum of first n natural numbers
            int actualSum = numbers.Sum(); // Sum Of given numbers in array
            return expectedSum - actualSum; ; //Missing Number
        }
    }
}
