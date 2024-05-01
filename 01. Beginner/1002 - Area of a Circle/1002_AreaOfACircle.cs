using System; 

class URI 
{
    static void Main(string[] args) 
    {     
        double r, a, pi = 3.14159;

        r = double.Parse(Console.ReadLine());

        a = pi * r * r;

        Console.WriteLine("A=" + a.ToString("F4"));
    }
}