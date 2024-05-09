using System;

class URI 
{
    static void Main(string[] args) 
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] numbers = Console.ReadLine().Split(' ');

            float xDividend = float.Parse(numbers[0]);
            float yDivisor = float.Parse(numbers[1]);

            if (yDivisor != 0)
            {
                float divisionResult = xDividend / yDivisor;
                Console.WriteLine($"{divisionResult:F1}");
            }
            else
                Console.WriteLine("divisao impossivel");
        } 
    }
}