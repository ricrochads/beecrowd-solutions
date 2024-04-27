using System;

class URI 
{
    static void Main(string[] args) 
    {
        int a, b;

        do
        {
            a = Math.Abs(int.Parse(Console.ReadLine()));
            b = Math.Abs(int.Parse(Console.ReadLine()));
        } while (a == 0 || a > 100000 || b > 100000);

        int remainder = a % b;

        Console.WriteLine(remainder);
    }
}