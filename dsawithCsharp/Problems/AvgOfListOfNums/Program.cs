using System;

namespace AvgOfListOfNums
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfNumbers = Helper.GetUnsortedList();
            var avg = Helper.GetAverageOf(listOfNumbers);
            Console.WriteLine($"Average of list of entered numbers : {avg}");
        }
    }
}
