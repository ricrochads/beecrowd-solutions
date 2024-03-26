using System;

class URI 
{
    static void Main(string[] args) 
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] values = Console.ReadLine().Split(' ');
            
            int x = int.Parse(values[0]);
            int y = int.Parse(values[1]);

            int oddSum = 0;

            if (x < y)
            {
                for (int currentNumber = x + 1; currentNumber < y; currentNumber++)
                {
                    oddSum += currentNumber % 2 != 0 ? currentNumber : 0;
                }
                Console.WriteLine(oddSum);
            }
            else
            {
                for (int currentNumber = y + 1; currentNumber < x; currentNumber++)
                {
                    oddSum += currentNumber % 2 != 0 ? currentNumber : 0;
                }
                Console.WriteLine(oddSum);
            }
        }
    }
}