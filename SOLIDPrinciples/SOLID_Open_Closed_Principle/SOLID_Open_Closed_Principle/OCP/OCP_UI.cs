using OCPLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Open_Closed_Principle.OCP
{
    internal class OCP_UI
    {
        internal static void Run()
        {
            List<IApplicantModel> applicants = new List<IApplicantModel>
            {
                new PersonModel{FirstName = "Rudresh", LastName = "Patre" },
                 new ManagerModel{FirstName = "Tim", LastName = "Corey" },
                  new ExecutiveModel{FirstName = "Robert", LastName = "Martin" }
            };

            List<EmployeeModel> employees = new List<EmployeeModel>();
            Accounts accountProcessor = new Accounts();

            foreach (var applicant in applicants)
            {
                employees.Add(applicant.AccountProcessor.Create(applicant));
            }

            foreach (var emp in employees)
            {
                Console.WriteLine($"{emp.FirstName} {emp.LastName}: {emp.Email} IsManager: {emp.IsManager} IsExecutive: {emp.IsExecutive}");
            }

            Console.ReadLine();
        }
    }
}
