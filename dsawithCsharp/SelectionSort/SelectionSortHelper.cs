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
            for (int i = 1; i < arr.Length; i++)
            {
                var newValue = arr[i];
                var j = i;
                while (j>0 && arr[j-1]>newValue)
                {
                    arr[j] = arr[j-1];
                    j--;
                }
                arr[j]=newValue;
            }

            return arr;
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