
using System;

class Program
{
    static void Main()
    {

        double d = 5e9d;
        Console.WriteLine(d);
        int i = checked((int)d);
        Console.WriteLine(i);

    }
}
