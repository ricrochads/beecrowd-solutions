using System;
using System.Collections.Generic;

class URI 
{
    static void Main(string[] args) 
    {
        int n = int.Parse(Console.ReadLine());
        
        int[] numbers = new int[n];
        numbers = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        List<int> li = new List<int>();
        List<int> multiplesOfTwo = new List<int>();
        List<int> multiplesOfThree = new List<int>();
        List<int> multiplesOfFour = new List<int>();
        List<int> multiplesOfFive = new List<int>();

        foreach (int number in numbers)
        {
            li.Add(number);

            if (number % 2 == 0)
                multiplesOfTwo.Add(number);
            if (number % 3 == 0)
                multiplesOfThree.Add(number);
            if (number % 4 == 0)
                multiplesOfFour.Add(number);
            if (number % 5 == 0)
                multiplesOfFive.Add(number);
        }

        Console.WriteLine($"{multiplesOfTwo.Count} Multiplo(s) de 2");
        Console.WriteLine($"{multiplesOfThree.Count} Multiplo(s) de 3");
        Console.WriteLine($"{multiplesOfFour.Count} Multiplo(s) de 4");
        Console.WriteLine($"{multiplesOfFive.Count} Multiplo(s) de 5");
    }
}