using System;

class URI 
{
    static void Main(string[] args) 
    {
        int t = int.Parse(Console.ReadLine());

        for (int i = 0; i < t; i++)
        {
            string[] input = Console.ReadLine().Split(' ');
            int n = int.Parse(input[0]);
            int k = int.Parse(input[1]);

            int bottlesSecondDay = n + (n / k) - (n / k * k);
            
            Console.WriteLine(bottlesSecondDay);
        } 
    }
}