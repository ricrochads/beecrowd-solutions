using System;

class URI 
{
    static void Main(string[] args) 
    {
        int a, b;

        do
        {
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
        } while (a == 0 || a > 100000 || b > 100000);

        int remainder = a % b;

        Console.WriteLine(remainder);
    }
}