using System; 

class URI 
{
    static void Main(string[] args) 
    {
        string[] input = Console.ReadLine().Split(' ');

        int code = int.Parse(input[0]);
        int quantity = int.Parse(input[1]);

        double[] prices = { 0, 4.00, 4.50, 5.00, 2.00, 1.50 };

        double total = prices[code] * quantity;

        Console.WriteLine($"Total: R$ {total:F2}");
    }
}