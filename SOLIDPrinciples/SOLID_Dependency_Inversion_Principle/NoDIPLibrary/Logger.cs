using System;
using System.Collections.Generic;
using System.Text;

namespace NoDIPLibrary
{
    public class Logger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Write to Console: { message }");
        }
    }
}
