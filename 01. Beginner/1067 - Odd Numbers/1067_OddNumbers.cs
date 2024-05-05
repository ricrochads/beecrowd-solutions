using System;

class URI 
{
    static void Main(string[] args) 
    {
        int number = int.Parse(Console.ReadLine());

        for (int i = 0; i <= number; i++)
        {
            if (i % 2 != 0)
                Console.WriteLine(i);
        }
    }
}