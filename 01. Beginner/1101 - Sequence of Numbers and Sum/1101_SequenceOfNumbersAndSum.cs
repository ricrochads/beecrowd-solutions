using System;

class URI 
{
    static void Main(string[] args) 
    {
        while (true)
        {
            string[] integerPairs = Console.ReadLine().Split(' ');
            int m = int.Parse(integerPairs[0]);
            int n = int.Parse(integerPairs[1]);

            if (m <= 0 || n <= 0)
                break;
            
            int smallestNumber = Math.Min(m, n);
            int biggestNumber = Math.Max(m, n);

            int sum = 0;

            for (int i = smallestNumber; i <= biggestNumber; i++)
            {
                sum += i;
                Console.Write($"{i} ");
            }

            Console.WriteLine($"Sum={sum}");
        };
    }
}