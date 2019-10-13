using System;

namespace VolumeOfCylinder.Validations
{
    public static class Validate
    {
        public static bool ValidateInputsHaveValueGreaterZero(double h, double r)
        {
            return h > 0 && r > 0;
        }
    }
}