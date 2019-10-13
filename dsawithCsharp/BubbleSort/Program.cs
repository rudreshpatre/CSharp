using System;
using BubbleSort.Helpers;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var unsortedNumbers = BubbleSortHelper.GetUnsortedList();
                Console.WriteLine("Unsorted List");
                BubbleSortHelper.PrintNumbers(unsortedNumbers);

                var bubbleSortedNumbers = BubbleSortHelper.BubbleSort(unsortedNumbers);

                System.Console.WriteLine("Bubble sorted List");
                BubbleSortHelper.PrintNumbers(bubbleSortedNumbers);
            }           

            catch (Exception ex)
            {
               if(ex.Message.Contains("Input string was not in a correct format")){
                   Console.WriteLine("Please enusure you are entering number as input.");
               }
            }
        }
    }
}
