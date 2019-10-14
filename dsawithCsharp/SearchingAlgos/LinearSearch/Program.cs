using System;

namespace LinearSearch
{
    class Program
    {
        static void Main(string[] args)
        {
             try
            {
                var arr = LinearSearchHelper.GetArrayList();
                LinearSearchHelper.PrintArray(arr);
                Console.WriteLine("Enter the number you want to search!");
                var searchKey = Convert.ToInt32(Console.ReadLine());
                arr = LinearSearchHelper.LinearSearch(arr,searchKey);
                LinearSearchHelper.PrintArray(arr);
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
