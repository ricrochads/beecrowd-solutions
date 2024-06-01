using System;
using System.Collections.Generic;

class URI 
{
    static void Main(string[] args) 
    {
        int n = int.Parse(Console.ReadLine());

        List<Tuple<int, char>> amountAndType = new List<Tuple<int, char>>();
        
        int totalAnimal = 0;
        int totalRabbit = 0;
        int totalRat = 0;
        int totalFrog = 0;

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split(' ');
            amountAndType.Add(Tuple.Create(int.Parse(input[0]), char.ToUpper(input[1][0])));

            totalAnimal += amountAndType[i].Item1;

            switch (amountAndType[i].Item2)
            {
                case 'C':
                    totalRabbit += amountAndType[i].Item1;
                    break;
                case 'R':
                    totalRat += amountAndType[i].Item1;
                    break;
                case 'S':
                    totalFrog += amountAndType[i].Item1;
                    break;
            }
        }

        double percentualRabbit = (double)totalRabbit / totalAnimal * 100;
        double percentualRat = (double)totalRat / totalAnimal * 100;
        double percentualFrog = (double)totalFrog / totalAnimal * 100;

        Console.WriteLine($"Total: {totalAnimal} cobaias");
        Console.WriteLine($"Total de coelhos: {totalRabbit}");
        Console.WriteLine($"Total de ratos: {totalRat}");
        Console.WriteLine($"Total de sapos: {totalFrog}");
        Console.WriteLine($"Percentual de coelhos: {percentualRabbit:F2} %");
        Console.WriteLine($"Percentual de ratos: {percentualRat:F2} %");
        Console.WriteLine($"Percentual de sapos: {percentualFrog:F2} %");
    }
}