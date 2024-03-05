using System;

class URI 
{
    static void Main(string[] args)
    {
    	int N, quotient;
        
        N = int.Parse(Console.ReadLine());
        Console.WriteLine(N);

        int[] notes = {100, 50, 20, 10, 5, 2, 1};
        
        foreach (int note in notes)
        {
            quotient = N / note;
            Console.WriteLine(quotient + " nota(s) de R$ " + note + ",00");
            N %= note;
        }
    }
}