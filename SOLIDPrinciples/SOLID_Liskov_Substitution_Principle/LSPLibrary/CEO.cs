using System;
using System.Collections.Generic;
using System.Text;

namespace LSPLibrary
{
    public class CEO:BaseEmployee, IManager
    {
        public override void CalculatePerHourRate(int rank)
        {
            decimal baseAmount = 150M;
            Salary = baseAmount * rank;
        }     

        public void GeneratePerformanceReview() 
        {
            Console.WriteLine("I'm reviewing a direct report's performance");
        }

        public void FireSomeone()
        {
            // Simulate firing someone
            Console.WriteLine("You're Fired!");
        }
    }
}
