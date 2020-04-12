using System;
using System.Collections.Generic;
using System.Text;

namespace OCPLibrary
{
    public class Accounts : IAccounts
    {
        public EmployeeModel Create(IApplicantModel applicant)
        {
            EmployeeModel output = new EmployeeModel();

            output.FirstName = applicant.FirstName;
            output.LastName = applicant.LastName;
            output.Email = $"{applicant.FirstName.Substring(0, 1)}{applicant.LastName}@daydreamers.com";

            return output;
        }
    }
}
