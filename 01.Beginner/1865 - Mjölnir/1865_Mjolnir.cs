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
            string[] heroAndForce = Console.ReadLine().Split(' ');
            string hero = heroAndForce[0];
            int force = int.Parse(heroAndForce[1]);
            avengers[hero] = force;

            if (hero == "Thor")
                Console.WriteLine('Y');
            else
                Console.WriteLine('N');
        }
    }
}