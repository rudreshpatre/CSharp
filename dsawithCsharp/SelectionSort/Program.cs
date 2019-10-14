using System;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var arr = SelectionSortHelper.GetUnsortedList();
                SelectionSortHelper.PrintArray(arr);
                arr = SelectionSortHelper.SelectionSort(arr);
                SelectionSortHelper.PrintArray(arr);
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
