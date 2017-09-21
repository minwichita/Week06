using System;
using System.Net;  // for web client
using System.IO;   // for stream writer


namespace Labweek06
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            ask(ref n);
            answer(n);
            Console.ReadKey();
        }
        static int ask(ref int n)
        {
            Console.Write("Enter number : ");
            n = int.Parse(Console.ReadLine());
            return n;
        }
        static int answer(int n)
        {
            Console.WriteLine("This number is : " + (n % 2 > 0 ? "Odd number" : "Even number"));
            return n;
        }
    }
}


