using System;
using System.Collections.Generic;

class URI 
{
    static void Main(string[] args) 
    {
        double[] numbers = new double[6];

        for (int i = 0; i < 6; i++)
            numbers[i] = double.Parse(Console.ReadLine());
        
        List<double> positiveNumbers = new List<double>();

        foreach (double number in numbers)
        {
            if (number > 0)
                positiveNumbers.Add(number);
        }

        Console.WriteLine($"{positiveNumbers.Count} valores positivos");
    }
}