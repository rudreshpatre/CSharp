using NoOCPLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Open_Closed_Principle.NoOCP
{
    internal class NO_OCP_UI
    {
        internal static void Run()
        {
            List<PersonModel> applicants = new List<PersonModel> 
            {
                new PersonModel{FirstName = "Rudresh", LastName = "Patre" },
                 new PersonModel{FirstName = "Tim", LastName = "Corey" },
                  new PersonModel{FirstName = "Robert", LastName = "Martin" }
            };

            List<EmployeeModel> employees = new List<EmployeeModel>();
            Accounts accountProcessor = new Accounts();

            foreach (var applicant in applicants)
            {
                employees.Add(accountProcessor.Create(applicant));
            }

            foreach (var emp in employees)
            {
                Console.WriteLine($"{emp.FirstName} {emp.LastName}: {emp.Email}");
            }

            Console.ReadLine();
        }
    }
}
