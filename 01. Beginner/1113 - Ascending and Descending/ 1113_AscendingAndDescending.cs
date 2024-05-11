using System;

class URI 
{
    static void Main(string[] args) 
    {
        string[] numberPairs;
        int x, y;

        do
        {
            numberPairs = Console.ReadLine().Split(' ');
            x = int.Parse(numberPairs[0]);
            y = int.Parse(numberPairs[1]);

            if (x < y)
                Console.WriteLine("Crescente");
            else if (x > y)
                Console.WriteLine("Decrescente");

        } while (x != y);
    }
}