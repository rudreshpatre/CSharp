using System;

namespace KthSmallest
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var arr = Helper.GetUnsortedList();
                Helper.PrintArray(arr);
                arr = Helper.InsertionSort(arr);

                System.Console.WriteLine("Enter the kth smallest element from the list.");
                var kthSmallest = int.Parse(Console.ReadLine());
                Console.WriteLine($"The {kthSmallest}th/rd number in the list is {arr[kthSmallest - 1]}");
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter all inputs as a number and ensure kthsmallest is less than the lenthg of your list.");
            }

        }
    }
}
