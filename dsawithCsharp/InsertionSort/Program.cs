using System;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
             try
            {
                var arr = InsertionSortHelper.GetUnsortedList();
                InsertionSortHelper.PrintArray(arr);
                arr = InsertionSortHelper.InsertionSort(arr);
                InsertionSortHelper.PrintArray(arr);
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
