using System;
using System.Collections.Generic;
using System.Text;

namespace NoLSPLibrary
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public Employee Manager { get; set; }
        public decimal Salary { get; set; }

        public virtual void AssignManager(Employee manager)
        {
            Manager = manager;
        }

        public virtual void CalculatePerHourRate(int rank)
        {
            decimal baseAmount = 12.50M;
            Salary = baseAmount + (rank * 2);
        }
    }
}
