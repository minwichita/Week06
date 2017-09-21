using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W06Assignment
{
    class Program
    {
        static void Main()
        {
            int B, L;
            Console.WriteLine("Enter the Begining and the Lasting Number for finding the primed numbers of 7 : ");
            B = int.Parse(Console.ReadLine());
            L = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}", (PrimeSeven(B, L)));
            Console.ReadKey();
        }

        static int PrimeSeven(int b, int l)
        {
            int S = 1;
            for (int i = b; i <= l; i++)
            {
                if (i % 7 == 0) S = i;
            }
            return S; 

        }

    }
}