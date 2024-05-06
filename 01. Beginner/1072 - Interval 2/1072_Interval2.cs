using System;

class URI 
{
    static void Main(string[] args) 
    {
        int totalNumber = int.Parse(Console.ReadLine());

        int[] numbers = new int[totalNumber];

        int numbersInInterval = 0;
        int valuesOutOfInterval = 0;

        for (int i = 0; i <= totalNumber - 1; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());

            if (numbers[i] >= 10 && numbers[i] <= 20)
                numbersInInterval++;
            else
                valuesOutOfInterval++;
        }
        
        Console.WriteLine($"{numbersInInterval} in");
        Console.WriteLine($"{valuesOutOfInterval} out");
    }
}