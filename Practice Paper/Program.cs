using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Delegates
{
    public class SeehowCallBackWorks
    {

        public void DoWork(Action<int> callback)
        {
            for (int i = 0; i < 1000; i++)
                callback(i);
        }

        public void Test()
        {
            DoWork((result) => Console.WriteLine(result + "-first"));
            DoWork((result) => Console.WriteLine(result + "-second"));
            DoWork((result) => Console.WriteLine(result + "-third"));
        }

        public static void Main(string[] args)
        {
            var test = new SeehowCallBackWorks();
            test.Test();
            Console.Read();
        }

        public static string MultiplyByTen(int number)
        {
            return number.ToString();
        }

        private  static string ThrowException(int number, Exception exception, string message)
        {
            if (number <= 0)
                throw exception;
            Console.WriteLine("Exception was thrown");
            return message;
        }

    }


}
