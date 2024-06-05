using System;

class URI 
{
    static void Main(string[] args) 
    {
        int x;

        while (true)
        {
            x = int.Parse(Console.ReadLine());

            if (x == 0)
                break;

            for (int i = 1; i <= x; i++)
            {
                if (i == x)
                    Console.Write(i);
                else
                    Console.Write(i + " ");
            } 
            
            Console.WriteLine();
        } 
    }
}