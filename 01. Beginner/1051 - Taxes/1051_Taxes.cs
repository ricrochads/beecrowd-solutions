using System;

class URI 
{
    static void Main(string[] args) 
    {
        double salary = double.Parse(Console.ReadLine());
        double tax = 0;

        if (salary <= 2000)
            Console.WriteLine("Isento");
        else if (salary <= 3000)
        {
            tax = (salary - 2000) * 0.08;
            Console.WriteLine($"R$ {tax:F2}");
        }
        else if (salary <= 4500)
        {
            tax = (1000 * 0.08) + ((salary - 3000) * 0.18);
            Console.WriteLine($"R$ {tax:F2}");
        }
        else
        {
            tax = (1000 * 0.08) + (1500 * 0.18) + ((salary - 4500) * 0.28);
            Console.WriteLine($"R$ {tax:F2}");
        }
    }
}