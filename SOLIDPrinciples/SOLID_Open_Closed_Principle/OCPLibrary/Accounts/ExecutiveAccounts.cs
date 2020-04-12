using System;
using System.Collections.Generic;
using System.Text;

namespace OCPLibrary
{
    public class ExecutiveAccounts : IAccounts
    {
        public EmployeeModel Create(IApplicantModel applicant)
        {
            EmployeeModel output = new EmployeeModel();

            output.FirstName = applicant.FirstName;
            output.LastName = applicant.LastName;
            output.Email = $"{applicant.FirstName}{applicant.LastName}@daydreamers.com";

            output.IsManager = true;
            output.IsExecutive = true;

            return output;
        }
    }
}
