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

            if (numbers[i] % 2 == 0 )
                evenCount++;
            else
                oddCount++;

            if (numbers[i] > 0 && numbers[i] != 0)
                positiveCount++;
            else if (numbers[i] != 0)
                negativeCount++;
        }

        Console.WriteLine($"{evenCount} valor(es) par(es)");
        Console.WriteLine($"{oddCount} valor(es) impar(es)");
        Console.WriteLine($"{positiveCount} valor(es) positivo(s)");
        Console.WriteLine($"{negativeCount} valor(es) negativo(s)");
    }
}