using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissingNumberFinderApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the int array separated by commas: ");
            string input = Console.ReadLine();
            int[] numbers = input.Split(',').Select(int.Parse).ToArray();
            var missingNumberFinderService = new MissingNumberFinderService(new MissingNumberFinder());
            int result = missingNumberFinderService.FindMissingNumber(numbers);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
