using System;
namespace BinarySearch
{
    public static class BinarySearchHelper{
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

        public static int[] BinarySearch(int[] arr, int searchKey)
        {
            var resultArr = new int[1] { -1};
            var lowerIndex = 0;
            var upperIndex = arr.Length - 1;         
            while (lowerIndex<=upperIndex)
            {
                var midIndex = (lowerIndex + upperIndex)/2;
                if(arr[midIndex] == searchKey){
                    resultArr[0] = arr[midIndex];                   
                    return resultArr;
                }
                if(arr[midIndex]>searchKey){
                    upperIndex = midIndex -1 ;
                }
                if(arr[midIndex]<searchKey){
                    lowerIndex = midIndex+1;
                }
            }
            return resultArr;
        }

        public static int[] InsertionSort(int[] arr){
            for (int i = 1; i < arr.Length; i++)
            {
                var newValue = arr[i];
                var j = i;
                while (j>0 && arr[j-1]>newValue)
                {
                    arr[j]=arr[j-1];
                    j--;
                }
                arr[j] = newValue;
            }
            return arr;
        }

        public static void PrintArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write($"{item} ");
                if (item == -1)
                {
                    Console.WriteLine("The requested value was not found in the list.");
                }            
            }
            Console.WriteLine(" ");
        }
    }
}