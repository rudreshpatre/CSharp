using SOLID_Single_Responsibility_Principle.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Single_Responsibility_Principle.Srp
{
    internal class SrpClass
    {
        internal static void Run()
        {
            StandardMessages.WelcomeMessages();

            //Ask for user information
            Person user = PersonDataCapture.Capture();

            //Checks to be sure if inputs are valid
            bool isUserValid = PersonValidator.Validate(user);

            if (isUserValid == false) 
            {
                StandardMessages.EndApplication();
                return;
            }

            // Create a username for the person
            AccountGenerator.CreateAccount(user);

            StandardMessages.EndApplication();
        }
    }
}
