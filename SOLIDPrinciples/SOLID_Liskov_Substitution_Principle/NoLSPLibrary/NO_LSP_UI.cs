using System;

namespace NoLSPLibrary
{
    public class NO_LSP_UI
    {
        public static void Run()
        {
            Manager accountingVP = new Manager();
            accountingVP.FirstName = "Emma";
            accountingVP.Lastname = "Stone";
            accountingVP.CalculatePerHourRate(4);

            Employee emp = new CEO();

            emp.FirstName = "Rudresh";
            emp.Lastname = "Patre";
            emp.AssignManager(accountingVP);
            emp.CalculatePerHourRate(2);

            Console.WriteLine($"{ emp.FirstName }'s salary is ${ emp.Salary }/hour.");

            Console.ReadLine();
        }
    }
}
