using System;
using VolumeOfCylinder.Validations;

namespace VolumeOfCylinder
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var pi = Math.PI;
                System.Console.WriteLine("Enter height of your cylinder");
                var h = Convert.ToDouble(Console.ReadLine());
                System.Console.WriteLine("Enter radius of your cylinder");
                var r = Convert.ToDouble(Console.ReadLine());
                if (Validate.ValidateInputsHaveValueGreaterZero(h, r))
                {
                    var volumeOfCylinder = pi * r * r * h;
                    Console.WriteLine($"Volume of a cylinder with radius: {r} and height: {h} is {volumeOfCylinder}");
                }
                else
                {
                    System.Console.WriteLine("Please ensure either Height or Radius of Cylinder is not zero or less than zero");
                }
            }
            catch (System.Exception)
            {
                System.Console.WriteLine("Please ensure you are only providing numbers as an input for and Height and Radius of cylinder");               
            }

        }
    }
}
