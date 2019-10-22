using System;

namespace DepthOfNestingParenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = "(b) ((c) ()";
            Console.WriteLine($"Depth of paranthesis is {Helper.GetMaxDepthOfNestingParenthesis(str)}");
        }
    }
}
