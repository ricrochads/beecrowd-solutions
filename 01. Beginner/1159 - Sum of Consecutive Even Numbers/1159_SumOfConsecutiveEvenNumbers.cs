using System; 

class URI
{
    static void Main(string[] args) 
    {
        int x, sum;

        while (true)
        {
            x = int.Parse(Console.ReadLine());
            
            if (x == 0)
                break;

            sum = 0;
            
            for (int i = 0; i < 5;)
            {
                if (x % 2 == 0)
                {
                    sum += x;
                    i++;
                }
                
                x++;
            }

            Console.WriteLine(sum);
        }
    }
}