using System;
using System.Collections.Generic;

class URI 
{
    static void Main(string[] args) 
    {
        int numberOfPurchases = Convert.ToInt32(Console.ReadLine());

        Dictionary<int, double> menu = new Dictionary<int, double>()
        {
            {1001, 1.50},
            {1002, 2.50},
            {1003, 3.50},
            {1004, 4.50},
            {1005, 5.50}
        };

        double purchaseAmount = 0;

        for (int i = 0; i < numberOfPurchases; i++)
        {
            string[] productQuantity = Console.ReadLine().Split(' ');
            int p = Convert.ToInt32(productQuantity[0]);
            int q = Convert.ToInt32(productQuantity[1]);

            purchaseAmount += menu[p] * q;
        }

        Console.WriteLine($"{purchaseAmount:F2}");
    }
}