using System;

class URI 
{
    static void Main(string[] args) 
    {
        double a = 234.345;
        double b = 45.698;

        Console.WriteLine($"{a:F6} - {b:F6}");
        Console.WriteLine($"{a:F0} - {b:F0}");
        Console.WriteLine($"{a:F1} - {b:F1}");
        Console.WriteLine($"{string.Format("{0:0.000}", a).Substring(0, 6)} - {string.Format("{0:0.00}", b)}");
        Console.WriteLine($"{a:0.000} - {b:0.000}");
        Console.WriteLine($"{a:0.#####0e+00} - {b:0.#####0e+00}");
        Console.WriteLine($"{a:0.#####0E+00} - {b:0.#####0E+00}");
        Console.WriteLine($"{a:g} - {b:g}");
        Console.WriteLine($"{a:G} - {b:G}");
    }
}