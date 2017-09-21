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
            int H, L1, L2;
            Console.Write("Enter height : ");
            H = int.Parse(Console.ReadLine());
            Console.Write("Enter long1 : ");
            L1 = int.Parse(Console.ReadLine());
            Console.Write("Enter long2 : ");
            L2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Trapezoid Area is : " + ans(H, L1, L2));
            Console.ReadKey();
        }
        static double ans(int H, int L1, int L2)
        {
            return (0.5 * (L1 + L2) * H);
        }
    }
}