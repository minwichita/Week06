using System;

class Program
{
    static void Main()
    {
        int val;   // do not initial value
        refMethod(out val);
        Console.WriteLine(val);
        Console.ReadLine();
    }

    static void refMethod(out int i)
    {
        i = i + 1;
    }
}
