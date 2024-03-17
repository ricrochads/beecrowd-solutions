using System; 

class URI 
{
    static void Main(string[] args) 
    {
        int a, b, c, d;

        String[] numbers = Console.ReadLine().Split(' ');
        
        a = int.Parse(numbers[0]);
        b = int.Parse(numbers[1]);
        c = int.Parse(numbers[2]);
        d = int.Parse(numbers[3]);

        if (b > c && d > a && c + d > a + b && c > 0 && d > 0 && a % 2 == 0) 
            Console.WriteLine("Valores aceitos");
        else
            Console.WriteLine("Valores nao aceitos");
    }
}