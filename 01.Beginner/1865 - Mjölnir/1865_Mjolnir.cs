using System;
using System.Collections.Generic;

class URI 
{
    static void Main(string[] args) 
    {
        int c = int.Parse(Console.ReadLine());

        Dictionary<string, int> avengers = new Dictionary<string, int>();

        for (int i = 0; i < c; i++)
        {
            string[] heroeAndForce = Console.ReadLine().Split(' ');
            string heroe = heroeAndForce[0];
            int force = int.Parse(heroeAndForce[1]);
            avengers[heroe] = force;

            if (heroe == "Thor")
                Console.WriteLine('Y');
            else
                Console.WriteLine('N');
        }
    }
}