using System;

class URI 
{
    static void Main(string[] args) 
    {
        int b, g;

        do
        {
            b = int.Parse(Console.ReadLine());
            g = int.Parse(Console.ReadLine());
        } while (b < 0 || g < 100);

        int totalBallsNeeded;

        totalBallsNeeded = g % 2 == 0 ? g / 2 : (g - 1) / 2;
        
        int numBallsToBuy = totalBallsNeeded - b;

        if (numBallsToBuy <= 0)
            Console.WriteLine("Amelia tem todas bolinhas!");
        else
            Console.WriteLine($"Faltam {numBallsToBuy} bolinha(s)");
    }
}