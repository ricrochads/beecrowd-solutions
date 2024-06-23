using System;
using System.Linq;

class URI
{
    static void Main(string[] args) 
    {
        int n = GetPositiveInteger();
        int[] x = ReadArray(n);
        
        int minValue = x.Min();
        int position = Array.IndexOf(x, minValue);

        Console.WriteLine($"Menor valor: {minValue}");
        Console.WriteLine($"Posicao: {position}");
    }

    static int GetPositiveInteger()
    {
        int number;
        bool isValid;

        do
        {
            string inputNumber = Console.ReadLine();
            isValid = int.TryParse(inputNumber, out number) && number > 1 && number < 1000;
        } while (!isValid);

        return number;
    }

    static int[] ReadArray(int n)
    {
        int[] x = new int[n];
        string[] inputValues = Console.ReadLine().Split(' ');
        
        for (int i = 0; i < n; i++)
            x[i] = int.Parse(inputValues[i]);

        return x;
    }
}