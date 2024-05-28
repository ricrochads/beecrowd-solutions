using System;

class URI 
{
    static void Main(string[] args) 
    {
        int i;
        string a = "a";

        do
            i = int.Parse(Console.ReadLine());
        while (i < 1 || i > Math.Pow(10, 4));

        for (int j = 1; j < i; j++)
            a += "a";

        Console.WriteLine($"Feliz nat{a}l!");
    }
}