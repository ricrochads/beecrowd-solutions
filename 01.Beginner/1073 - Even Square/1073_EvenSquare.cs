using System;

class URI 
{
    static void Main(string[] args) 
    {
        int n = int.Parse(Console.ReadLine());

        for (int currentNumber = 1; currentNumber <= n; currentNumber++)
        {
            if (currentNumber % 2 == 0)
            {
                double squaredValue = Math.Pow(currentNumber, 2);
                Console.WriteLine($"{currentNumber}^2 = {squaredValue}");
            }
        }
    }
}