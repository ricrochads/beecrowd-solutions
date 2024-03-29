using System;

class URI 
{
    static void Main(string[] args) 
    {
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());

        int largerNumber = Math.Max(x, y);
        int smallerNumber = Math.Min(x, y);

        int sumNonDivBy13 = 0;

        for (int i = smallerNumber; i <= largerNumber; i++)
        {
            if (i % 13 != 0)
                sumNonDivBy13 += i;
        }

        Console.WriteLine(sumNonDivBy13);
    }
}