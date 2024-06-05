using System;

class URI 
{
    static void Main(string[] args) 
    {
        int x, y;
        int count = 0;

        do
        {
            var input = Console.ReadLine().Split(' ');
            x = int.Parse(input[0]);
            y = int.Parse(input[1]);
        } while (x < 1 && x > 20 && x > y);

        for (int i = 1; i <= y; i++)
        {
            Console.Write(i);
            count++;

            if (count == x)
            {
                Console.WriteLine("");
                count = 0;
            }
            else
            {
                Console.Write(" ");
            }
        } 
    }
}