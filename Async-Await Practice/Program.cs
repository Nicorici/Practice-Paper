using System;
using System.Threading;
using System.Threading.Tasks;
using System.Text;
namespace Async_Await_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            GetString();
            Console.Read();
        }

        static async Task GetString()
        {
            await GetAsync();
        }
        fefefefefef
        static async Task<string> GetAsync()
        {
            Task t = Task.Run(() => Iterate());
            Console.WriteLine("started task async");
            DoExtraWork();
            await t;
            Console.WriteLine("Exited await...");
        }

        private static void DoExtraWork()
        {
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(150);
                Console.WriteLine($"Extra work {i}");
            }
        }

        public static int Iterate()
        {
            for (int i = 0; i < 250; i++)
            {
                if (i % 10 == 0)
                {
                    Thread.Sleep(200);
                    Console.WriteLine($"Reached {i}");
                }
            }
            return 99999;
        }
    }
}
