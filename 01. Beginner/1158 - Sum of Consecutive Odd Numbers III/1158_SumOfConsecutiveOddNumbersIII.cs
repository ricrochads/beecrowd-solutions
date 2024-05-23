using System;

class URI 
{
    static void Main(string[] args) 
    {
        int n = int.Parse(Console.ReadLine());
        int testCase = 1;

        while (testCase <= n)
        {
            string[] integers = Console.ReadLine().Split(' ');

            int x = int.Parse(integers[0]);
            int y = int.Parse(integers[1]);

            int oddNumbersSum = 0;

            for (int i = 0; i < y;)
            {
                if (x % 2 != 0)
                {
                    oddNumbersSum += x;
                    i++;
                }
                x++;
            }
            
            Console.WriteLine(oddNumbersSum);
            testCase++; 
        }
    }
}