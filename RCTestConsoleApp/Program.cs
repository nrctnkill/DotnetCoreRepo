using System;

namespace RCTestConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int res = Add(6, 5);
            Console.WriteLine("Result:"+res);
        }

        static int Add(int a,int b)
        {
            return a + b;
        }
    }
}
