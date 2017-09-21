
using System;

class Program
{
    static void Main()
    {
        double d = 5e9d;
        Console.WriteLine(d);
        try
        {


            int i = checked((int)d);
            Console.WriteLine(i);
        }
        catch (OverflowException e)
        {
            Console.WriteLine(e.Message);
        }

    }
}
