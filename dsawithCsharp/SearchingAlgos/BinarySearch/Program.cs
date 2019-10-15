using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var arr = BinarySearchHelper.GetArrayList();
                BinarySearchHelper.PrintArray(arr);
                arr = BinarySearchHelper.InsertionSort(arr);
                Console.WriteLine("Enter number you want to search.");
                var searchKey = Convert.ToInt32(Console.ReadLine());
                arr = BinarySearchHelper.BinarySearch(arr, searchKey);
                BinarySearchHelper.PrintArray(arr);
            }
            catch (System.Exception ex)
            {
                if (ex.Message.Contains("Input string was not in a correct format"))
                {
                    Console.WriteLine("Please enusure you are entering number as input.");
                }
            }
        }
    }
}
