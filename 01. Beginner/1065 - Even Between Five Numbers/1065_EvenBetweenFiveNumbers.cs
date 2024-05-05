using System;
using System.Collections.Generic;

class URI 
{
    static void Main(string[] args) 
    {
        int[] numbers = new int[5];

        for (int i = 0; i < 5; i++)
            numbers[i] = int.Parse(Console.ReadLine());
        
        List<int> evenNumbers = new List<int>();

        foreach (int number in numbers)
        {
            if (number % 2 == 0)
                evenNumbers.Add(number);
        }

        Console.WriteLine($"{evenNumbers.Count} valores pares");
    }
}