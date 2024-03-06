using System; 

class URI 
{
    static void Main(string[] args) 
    {
        int days, months, years;

        days = int.Parse(Console.ReadLine());

        years = days / 365;
        days %= 365;
        months = days / 30;
        days %= 30;

        Console.WriteLine(years + " ano(s)");  
        Console.WriteLine(months + " mes(es)");  
        Console.WriteLine(days + " dia(s)");   
    }
}