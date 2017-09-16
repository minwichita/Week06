
using System;

class Program
{
    static void Main()
    {
        int val = 999;
        refMethod(out val);
        Console.WriteLine(val);
        Console.ReadLine();
    }

    static void refMethod(out int i)
    {
        i = i + 1;
    }
}
