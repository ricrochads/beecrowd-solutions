using System;
using System.Linq;

class URI 
{
    static void Main(string[] args) 
    {
        int[] mealsAvailable = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        var (cA, bA, pA) = (mealsAvailable[0], mealsAvailable[1], mealsAvailable[2]);

        int[] mealsRequested = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        var (cR, bR, pR) = (mealsRequested[0], mealsRequested[1], mealsRequested[2]);

        int passengersWithoutMeals = 0;

        passengersWithoutMeals += Math.Max(0, cR - cA);
        passengersWithoutMeals += Math.Max(0, bR - bA);
        passengersWithoutMeals += Math.Max(0, pR - pA);

        Console.WriteLine(passengersWithoutMeals);
    }
}