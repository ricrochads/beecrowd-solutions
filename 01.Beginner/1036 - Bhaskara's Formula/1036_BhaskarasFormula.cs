using System; 

class URI 
{
    static void Main(string[] args) 
    {
        double a, b, c, r1, r2, delta;

        String[] coefficients = Console.ReadLine().Split(' ');

        a = double.Parse(coefficients[0]);
        b = double.Parse(coefficients[1]);
        c = double.Parse(coefficients[2]);

        delta = (b * b) - (4 * a * c);
            
        if (a == 0 || delta < 0) 
            Console.WriteLine("Impossivel calcular"); 
        else 
        {
            r1 = ((-b) + Math.Sqrt(delta)) / (2 * a);
            r2 = ((-b) - Math.Sqrt(delta)) / (2 * a);

            Console.WriteLine("R1 = " + r1.ToString("F5"));
            Console.WriteLine("R2 = " + r2.ToString("F5"));
        }
    }
}