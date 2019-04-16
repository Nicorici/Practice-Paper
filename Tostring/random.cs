using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Web;
using System.Linq;
namespace Tostring
{
    public class Random
    {
        public  Action<string> Concatenation;
        public  Action<int> Divisors;
        public event EventHandler ProcessExit;

        public void Iterate()
        {
            int count = 0;
            string result = "";
            for (char c = 'a'; c < char.MaxValue; c++)
            {
                result += c.ToString();
                count++;
                if (count % 2 == 0)
                    Concatenation?.Invoke(result);
                Console.WriteLine("after callback in string runtime.");
            }
        }

        public void Add()
        {
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 == 0)
                    Divisors(i);
                Console.WriteLine(" after callback in string runtime.");
                if (i == 99)
                    ProcessExit();
            }

        }

    }
}
