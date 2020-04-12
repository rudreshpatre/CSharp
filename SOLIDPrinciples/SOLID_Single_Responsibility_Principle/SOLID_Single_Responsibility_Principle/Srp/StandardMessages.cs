using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Single_Responsibility_Principle.Srp
{
    internal class StandardMessages
    {
        internal static void WelcomeMessages() 
        {
            Console.WriteLine("Welcome to my application!");
        }

        internal static void EndApplication()
        {
            Console.WriteLine("Press Enter to close");
            Console.ReadLine();
        }

        internal static void DisplayValidationError(string fieldName)
        {
            Console.WriteLine($"You did not give us a valid { fieldName }!");
        }
    }
}
