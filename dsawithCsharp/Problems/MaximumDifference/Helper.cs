using System;
namespace MaximumDifference
{
    public static class Helper
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

        public static int MaximumDifference(int[] arr)
        {
            var maxDiff = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        var _maxDiff = arr[j] - arr[i];
                        maxDiff = _maxDiff>maxDiff ? _maxDiff : maxDiff;
                    }
                }
            }
            return maxDiff;
        }

        public static void PrintArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine(" ");
        }

    }
}