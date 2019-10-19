using System;
namespace AvgOfListOfNums
{
    public class Helper
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
                Console.WriteLine(" ");
                return unsortedNumbers;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public static double GetAverageOf(int[] arr)
        {
            try
            {
                var LengthOfArray = arr.Length;
                var SumOfNumbers = 0;
                foreach (var number in arr)
                {
                    SumOfNumbers+=number;
                }
                return SumOfNumbers / LengthOfArray;
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
}