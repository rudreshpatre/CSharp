using System;
namespace LinearSearch
{
    public class LinearSearchHelper
    {
        public static int[] GetArrayList()
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

        public static int[] LinearSearch(int[] arr, int searchKey)
        {
            var resultArr = new int[1] { -1 };
            foreach (var item in arr)
            {                
                if (item == searchKey)
                {
                    resultArr[0] = item;
                    break;
                }
            }
            return resultArr;
        }

        public static void PrintArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write($"{item} ");
                if (item == -1)
                {
                    System.Console.WriteLine("The requested value was not found in the list.");
                }
            }
            Console.WriteLine(" ");
        }
    }

}