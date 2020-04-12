using System;
using System.Collections.Generic;
using System.Text;

namespace NoOCPLibrary
{
    public class Accounts
    {
        public EmployeeModel Create(PersonModel applicant)
        {
            EmployeeModel output = new EmployeeModel();

            output.FirstName = applicant.FirstName;
            output.LastName = applicant.LastName;
            output.Email = $"{applicant.FirstName.Substring(0,1)}{applicant.LastName}@daydreamers.com";

            return output;
        }
    }
}
