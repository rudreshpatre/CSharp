using System;

namespace LSPLibrary
{
    public class LSP_UI
    {
        public static void Run()
        {
            IManager accountingVP = new Manager();
            accountingVP.FirstName = "Emma";
            accountingVP.Lastname = "Stone";
            accountingVP.CalculatePerHourRate(4);

            IManaged emp = new Manager();

            emp.FirstName = "Rudresh";
            emp.Lastname = "Patre";
            emp.AssignManager(accountingVP);
            emp.CalculatePerHourRate(2);

            Console.WriteLine($"{ emp.FirstName }'s salary is ${ emp.Salary }/hour.");

            Console.ReadLine();
        }
    }
}
