using System;

class URI 
{
    static void Main(string[] args) 
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] numbers = Console.ReadLine().Split(' ');

            float number1 = float.Parse(numbers[0]);
            float number2 = float.Parse(numbers[1]);
            float number3 = float.Parse(numbers[2]);

            float weightedAverage = (number1 * 2 + number2 * 3 + number3 * 5) / 10;
            Console.WriteLine($"{weightedAverage:F1}");
        }
    }
}