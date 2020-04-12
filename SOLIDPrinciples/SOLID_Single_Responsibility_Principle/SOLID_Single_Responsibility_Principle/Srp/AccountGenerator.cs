using SOLID_Single_Responsibility_Principle.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Single_Responsibility_Principle.Srp
{
    internal class AccountGenerator
    {
        public static void CreateAccount(Person user)
        {
            Console.WriteLine($"Your username is { user.FirstName.Substring(0, 1) }{ user.LastName }");
        }
    }
}
