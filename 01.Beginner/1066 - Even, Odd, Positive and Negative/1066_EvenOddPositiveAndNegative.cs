using System;

class URI 
{
    static void Main(string[] args) 
    {
        int[] numbers = new int[5];

        int evenCount = 0;
        int oddCount = 0;
        int positiveCount = 0;
        int negativeCount = 0;

        for (int i = 0; i < 5; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());

            evenCount += (numbers[i] % 2 == 0) ? 1 : 0;
            oddCount += (numbers[i] % 2 != 0) ? 1 : 0;
            positiveCount += (numbers[i] > 0) ? 1 : 0;
            negativeCount += (numbers[i] < 0) ? 1 : 0;
        }

        Console.WriteLine($"{evenCount} valor(es) par(es)");
        Console.WriteLine($"{oddCount} valor(es) impar(es)");
        Console.WriteLine($"{positiveCount} valor(es) positivo(s)");
        Console.WriteLine($"{negativeCount} valor(es) negativo(s)");
    }
}