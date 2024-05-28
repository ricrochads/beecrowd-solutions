using System;

class URI 
{
    static void Main(string[] args) 
    {
        string line;

        while ((line = Console.ReadLine()) != null)
        {
            string[] ni = line.Split(' ');
            int n = int.Parse(ni[0]);
            int cs = 0;
            
            for (int x = 0; x < n; x++)
            {
                string[] ij = Console.ReadLine().Split(' ');
                        
                if (ij[0] == ni[1] && ij[1] == "0")
                    cs++;
            }
            
            Console.WriteLine(cs);
        }
    }
}