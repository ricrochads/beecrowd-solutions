using System;
using System.Collections.Generic;

class URI 
{
    static void Main(string[] args) 
    {
        int ddd = int.Parse(Console.ReadLine());

        Dictionary<int, string> dddDestination = new Dictionary<int, string>()
        {
            { 61, "Brasilia" },
            { 71, "Salvador" },
            { 11, "Sao Paulo" },
            { 21, "Rio de Janeiro" },
            { 32, "Juiz de Fora" },
            { 19, "Campinas"},
            { 27, "Vitoria" },
            { 31, "Belo Horizonte"}
        };

        if (dddDestination.ContainsKey(ddd))
            Console.WriteLine(dddDestination[ddd]);
        else
            Console.WriteLine("DDD nao cadastrado");
    }
}