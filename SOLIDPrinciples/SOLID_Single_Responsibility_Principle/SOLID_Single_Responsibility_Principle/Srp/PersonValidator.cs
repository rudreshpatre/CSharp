using SOLID_Single_Responsibility_Principle.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Single_Responsibility_Principle.Srp
{
    internal class PersonValidator
    {
        internal static bool Validate(Person user)
        {
            if (string.IsNullOrWhiteSpace(user.FirstName))
            {
                StandardMessages.DisplayValidationError("first name");         
                return false;
            }

            if (string.IsNullOrWhiteSpace(user.LastName))
            {
                StandardMessages.DisplayValidationError("last name");
                return false;
            }

            return true;
        }
    }
}
