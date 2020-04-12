using SOLID_Open_Closed_Principle.NoOCP;
using SOLID_Open_Closed_Principle.OCP;
using System;

namespace SOLID_Open_Closed_Principle
{
    class Program
    {
        static void Main(string[] args)
        {
            ///OCP stands for Open Closed Principle

            //NO_OCP_UI.Run();
            //The existing functionality needs to identify employess as managers and executives
            OCP_UI.Run();
        }
    }
}
