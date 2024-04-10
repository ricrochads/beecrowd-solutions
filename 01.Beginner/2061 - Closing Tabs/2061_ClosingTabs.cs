using System;
using System.Linq;

class URI 
{
    static void Main(string[] args) 
    {
        var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        var (n, m) = (input[0], input[1]);
        int tabs = n;

        for (int i = 0; i < m; i++)
        {
            string action = Console.ReadLine().ToLower();

            switch (action)
            {
                case "fechou":
                    tabs++;
                    break;
                case "clicou":
                    tabs--;
                    break;
            }
        }

        Console.WriteLine(tabs);
    }
}