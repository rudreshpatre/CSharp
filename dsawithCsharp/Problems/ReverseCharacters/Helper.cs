using System;
namespace ReverseCharacters
{
    public class Helper
    {
        public static string GetString()
        {
            try
            {
                Console.WriteLine("Enter your string.");
                var str = Console.ReadLine();
                return str;
            }
            catch (System.Exception)
            {
                throw;
            }
        }
        public static string ReverseCharacters(string str)
        {
            try
            {
                var chars = str.ToCharArray();
                var revStr = "";
                for (int i = chars.Length - 1; i >= 0; i--)
                {
                    revStr += chars[i];
                }
                return revStr;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public static string ReverseCharactersWithinSameArray(string str)
        {
            try
            {
                var chars = str.ToCharArray();
                var first = 0;
                var last = chars.Length - 1;
                var iterationLength = last / 2;//if length of the array is odd anyways we do not have to consider the item for reversal, this lenth determines exact point of iterarion to accomplish it.
                for (int i = 0; i < iterationLength; i++)
                {
                    Swap(chars,first,last);
                    first++;
                    last--;
                }
                str = "";
                foreach (var item in chars)
                {
                    str +=item;
                }
                return str;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        private static void Swap(char[] arr, int first, int last)
        {
            var tmp = arr[first];
            arr[first] = arr[last];
            arr[last] = tmp;
        }
    }
}