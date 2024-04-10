using System;

class URI 
{
    static void Main(string[] args) 
    {
        string input;
        int n, password;
        
        while ((input = Console.ReadLine()) != null)
        {
            n = int.Parse(input);
            
            if (n >= 1000 && n <= 9999)
            {
                password = n - 1;
                Console.WriteLine(password);
            }
        }
    }
}