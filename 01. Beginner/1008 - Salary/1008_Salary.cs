using System; 

class URI 
{
    static void Main(string[] args) 
    {
        int number, hours;
        double hourValue, salary;
    
        number = int.Parse(Console.ReadLine());
        hours = int.Parse(Console.ReadLine());
        hourValue = double.Parse(Console.ReadLine());

        salary = hourValue * hours;
    
        Console.WriteLine("NUMBER = " + number);
        Console.WriteLine("SALARY = U$ " + salary.ToString("F2"));
    }
}