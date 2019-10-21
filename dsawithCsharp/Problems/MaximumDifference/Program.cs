using System;

namespace MaximumDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var arr = Helper.GetUnsortedList();
                Console.WriteLine($"Max Difference in list is: {Helper.MaximumDifference(arr)}");
            }
            catch (Exception)
            {
              Console.WriteLine("Please ensure all the inputs are numbers.");
            }

        }
    }
}
