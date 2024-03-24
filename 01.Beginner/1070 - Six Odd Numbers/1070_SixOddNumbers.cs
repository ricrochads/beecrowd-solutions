using System;

class URI 
{
    static void Main(string[] args) 
    {
        int number = int.Parse(Console.ReadLine());

        int oddNumberCount = 0;

        for (int i = number; oddNumberCount <= 5; i++)
        {
            if (i % 2 != 0)
            {
                Console.WriteLine(i);
                oddNumberCount++;
            }
        }
    }
}