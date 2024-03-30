using System;

class URI 
{
    static void Main(string[] args) 
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            double squaredValue = Math.Pow(i, 2);
            double cubicValue = Math.Pow(i, 3);

            Console.WriteLine($"{i} {squaredValue} {cubicValue}");
        }
    }
}