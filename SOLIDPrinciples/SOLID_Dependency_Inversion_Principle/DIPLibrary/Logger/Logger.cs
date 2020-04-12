using System;
using System.Collections.Generic;
using System.Text;

namespace DIPLibrary
{
    public class Logger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Write to Console: { message }");
        }
    }
}
