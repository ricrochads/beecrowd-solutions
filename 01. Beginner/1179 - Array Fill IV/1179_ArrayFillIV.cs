using System;

class URI
{
    static void Main(string[] args) 
    {
        int[] evenNumbers = new int[5];
        int[] oddNumbers = new int[5];
        int evenIndex = 0;
        int oddIndex = 0;

        for (int i = 0; i < 15; i++)
        {
            int number = GetValidatedIntegerNumber();

            if (number % 2 == 0)
            {
                evenNumbers[evenIndex] = number;
                evenIndex++;

                if (evenIndex == 5)
                {
                    PrintArray("par", evenNumbers, evenIndex);                    
                    evenIndex = 0;
                }
            }
            else
            {
                oddNumbers[oddIndex] = number;
                oddIndex++;

                if (oddIndex == 5)
                {
                    PrintArray("impar", oddNumbers, oddIndex);
                    oddIndex = 0;
                }
            }
        }

        PrintArray("impar", oddNumbers, oddIndex);
        PrintArray("par", evenNumbers, evenIndex);
    }

    private static int GetValidatedIntegerNumber()
    {
        int number;

        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out number))
                return number;
        }
    }

    private static void PrintArray(string name, int[] array, int length)
    {
        for (int i = 0; i < length; i++)
            Console.WriteLine($"{name}[{i}] = {array[i]}");
    }
}