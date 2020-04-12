using SOLID_Single_Responsibility_Principle.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Single_Responsibility_Principle.Srp
{
    internal class PersonDataCapture
    {
        internal static Person Capture() 
        {
            Person output = new Person();

            Console.Write("What is your first name: ");
            output.FirstName = Console.ReadLine().Trim();

            Console.Write("What is your last name: ");
            output.LastName = Console.ReadLine().Trim();

            return output;
        }
    }
}
