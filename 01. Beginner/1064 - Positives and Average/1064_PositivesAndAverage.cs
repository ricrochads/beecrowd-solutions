using System;
using System.Linq;
using System.Collections.Generic;

class URI 
{
    static void Main(string[] args) 
    {
        float number;
        List<float> numbers = new List<float>();

        for (int i = 0; i < 6; i++)
        {
            number = float.Parse(Console.ReadLine());
            numbers.Add(number);
        }

        IEnumerable<float> positiveNumbers = numbers.Where(n => n > 0);

        Console.WriteLine($"{positiveNumbers.Count()} valores positivos");
        Console.WriteLine($"{positiveNumbers.Average():F1}");
    }
}