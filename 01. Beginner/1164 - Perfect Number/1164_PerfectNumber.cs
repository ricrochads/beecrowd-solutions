using System; 

class URI
{
    static void Main(string[] args) 
    {
        int n, x;

        do
            n = int.Parse(Console.ReadLine());
        while (n < 1);
        
        for (int i = 0; i < n;)
        {
            x = int.Parse(Console.ReadLine());

            if (!IsPositiveNumber(x))
                continue;

            if (IsPerfectNumber(x))
                Console.WriteLine($"{x} eh perfeito");
            else
                Console.WriteLine($"{x} nao eh perfeito");
            
            i++;
        }
    }

    static bool IsPositiveNumber(int x)
    {
        return x >= 1;
    }

    static bool IsPerfectNumber(int x)
    {
        int sum = 0;

        for (int i = 1; i < x; i++)
        {
            if (x % i == 0)
                sum += i;
        }

        return sum == x;
    }
}