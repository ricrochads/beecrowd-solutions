using System; 

class URI 
{
    static void Main(string[] args) 
    {
        double N = double.Parse(Console.ReadLine());

        Console.WriteLine("NOTAS:");
        
        int[] banknotes = { 100, 50, 20, 10, 5, 2 };

        for (int i = 0; i < banknotes.Length; i++)
        {
            int banknotesCount = (int)(N / banknotes[i]);
            Console.WriteLine($"{banknotesCount} nota(s) de R$ {banknotes[i]:.00}");
            N %= banknotes[i];
        }

        Console.WriteLine("MOEDAS:");

        N = (int)(N * 100.0 + 0.5);

        int coinValue = 100;
        int quotient = (int)(N / coinValue);
        Console.WriteLine($"{quotient} moeda(s) de R$ 1.00");
        N %= coinValue;

        coinValue = 50;
        quotient = (int)(N / coinValue);
        Console.WriteLine($"{quotient} moeda(s) de R$ 0.50");
        N %= coinValue;

        coinValue = 25;
        quotient = (int)(N / coinValue);
        Console.WriteLine($"{quotient} moeda(s) de R$ 0.25");
        N %= coinValue;

        coinValue = 10;
        quotient = (int)(N / coinValue);
        Console.WriteLine($"{quotient} moeda(s) de R$ 0.10");
        N %= coinValue;

        coinValue = 5;
        quotient = (int)(N / coinValue);
        Console.WriteLine($"{quotient} moeda(s) de R$ 0.05");
        N %= coinValue;

        Console.WriteLine($"{N} moeda(s) de R$ 0.01");
    }
}