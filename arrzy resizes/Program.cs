using System;
using System.Net;
using System.Net.Sockets;
using System.Linq;
using System.Text;
using System.Threading;

namespace arrzy_resizes
{
    public class Program
    {
        public delegate void Write(string message);
        static void Main(string[] args)
        {
            string c = "aaaaaaaaaaabc";
            int index = c.IndexOf('b');
            string s = c.Substring(0, index);
        }

        public static void Iterate(Action<string> ConsoleRead)
        {
            string result = "";
            char c = 'd';
            for (char a = 'a'; a <= c; a++)
            {
                result += a;
                if (a == c)
                    ConsoleRead(result);
            }

        }
        static void Read(string c)
        {
            Console.WriteLine(c);
        }


    }
}
