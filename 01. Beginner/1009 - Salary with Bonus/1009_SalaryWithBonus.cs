using System; 

class URI 
{
    static void Main(string[] args) 
    { 
        string name;
        double salary, totalSales, totalSalary;

        name = Console.ReadLine();
        salary = double.Parse(Console.ReadLine());
        totalSales = double.Parse(Console.ReadLine());

        totalSalary = salary + totalSales * 0.15;

        Console.WriteLine("TOTAL = R$ " + totalSalary.ToString("F2"));
    }
}