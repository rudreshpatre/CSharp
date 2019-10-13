using System;

namespace BubbleSort.Helpers
{
    public static class BubbleSortHelper
    {
        public static int[] GetUnsortedList()
        {
            try
            {
                System.Console.WriteLine("Enter the length of your unsorted number list");
                var lengthOfUnsortedNumberList = Convert.ToInt32(Console.ReadLine());
                var unsortedNumbers = new int[lengthOfUnsortedNumberList];
                var iteration = 0;
                while (iteration < lengthOfUnsortedNumberList)
                {
                    System.Console.WriteLine($"Enter {iteration + 1} number in your list of {lengthOfUnsortedNumberList} number.");
                    var number = Convert.ToInt32(Console.ReadLine());
                    unsortedNumbers[iteration] = number;
                    iteration++;
                }
                return unsortedNumbers;
            }
            catch (System.Exception )
            {
                throw;
            }
        }

        public static void PrintNumbers(int[] numbers)
        {
            foreach (var number in numbers)
            {
                System.Console.Write($"{number} ");
            }
            System.Console.WriteLine("");
        }

        public static int[] BubbleSort(int[] unsortedNumbers)
        {
            bool swapped;
            do
            {
                swapped = false;
                for (int i = 0; i < unsortedNumbers.Length - 1; i++)
                {
                    if (unsortedNumbers[i] > unsortedNumbers[i + 1])
                    {
                        var temp = unsortedNumbers[i];
                        unsortedNumbers[i] = unsortedNumbers[i + 1];
                        unsortedNumbers[i + 1] = temp;
                        swapped = true;
                    }
                }
            }
            while (swapped);
            return unsortedNumbers;
        }
    }
}