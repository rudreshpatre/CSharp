using System;

namespace ReverseCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
           var str = Helper.GetString();
           Console.WriteLine($"Reversed chars :{Helper.ReverseCharacters(str)}");
           System.Console.WriteLine(    );
           Console.WriteLine($"Reversed chars within Same Array :{Helper.ReverseCharactersWithinSameArray(str)}");
        }
    }
}
