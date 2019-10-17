using System;

namespace SelectionSort
{
    public static class SelectionSortHelper{

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
            catch (System.Exception )
            {
                throw;
            }
        }      

         public static int[] SelectionSort (int[] arr){
            for (var i = 0; i < arr.Length; i++)
            {
                var start = i;
                var lowest = i;
                for (var j = i + 1; j < arr.Length; j++)
                {
                    if (arr[lowest] > arr[j])
                    {
                        lowest = j;
                    }
                }
                Swap(arr, start, lowest);
            }

            return arr;
        }

        private static void Swap(int[] arr, int start, int lowest)
        {
            var tmp = arr[start];
            arr[start] = arr[lowest];
            arr[lowest] = tmp;
        }

        public static void PrintArray(int[] arr){
            foreach (var item in arr)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine(" ");
        }
    }
    
}