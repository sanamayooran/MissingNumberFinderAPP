using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissingNumberFinderApp
{
    public class MissingNumberFinderService
    
    {
        private readonly IMissingNumberFinder _missingNumberFinder;
        public MissingNumberFinderService(IMissingNumberFinder missingNumberFinder) 
        {
        _missingNumberFinder = missingNumberFinder;
        }
        public int FindMissingNumber (int [] numbers)
        {
            return _missingNumberFinder.FindMissingNumber(numbers);
        }
       
    }
}
