using System;

namespace Tostring
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            r.Divisors +=s=> Print(s.ToString());
            r.Concatenation += Print;
            r.Add();
            Console.Read();
        }

        private static void Print(string s)
        {
            Console.WriteLine(s.ToString());
        }
    }
}
