using System;

class URI 
{
    static void Main(string[] args) 
    {
        double salary, readjustmentRate, moneyEarned, newSalary;

        salary = double.Parse(Console.ReadLine());
        
        if (salary <= 400.00)
            readjustmentRate = 15.00;
        else if (salary <= 800.00)
            readjustmentRate = 12.00;
        else if (salary <= 1200.00)
            readjustmentRate = 10.00;
        else if (salary <= 2000.00)
            readjustmentRate = 7.00;
        else
            readjustmentRate = 4.00;

        moneyEarned = salary * readjustmentRate / 100;
        newSalary = salary + moneyEarned;

        Console.WriteLine($"Novo salario: {newSalary:F2}"); 
        Console.WriteLine($"Reajuste ganho: {moneyEarned:F2}"); 
        Console.WriteLine($"Em percentual: {readjustmentRate} %"); 
    }
}