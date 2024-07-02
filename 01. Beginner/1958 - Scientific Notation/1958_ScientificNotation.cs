using System;

class URI
{
    static void Main(string[] args)
    {
        string x = Console.ReadLine();

        if (x.Equals("-0"))
            Console.WriteLine($"{double.Parse(x):-0.0000E+00}");
        else if (x.StartsWith("-"))
            Console.WriteLine($"{double.Parse(x):0.0000E+00}");
        else
            Console.WriteLine($"{double.Parse(x):+0.0000E+00}");
    }
}