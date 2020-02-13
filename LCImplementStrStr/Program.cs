using System;

namespace LCImplementStrStr
{
    class Program
    {
        static void Main(string[] args)
        {
            string haystack = "hello";

            string needle = "";

            Console.WriteLine(StrStr(haystack, needle));

            int StrStr(string haystack, string needle)
            {
                return haystack.IndexOf(needle);
            }
        }
    }
}
