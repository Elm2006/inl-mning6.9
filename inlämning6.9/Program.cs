using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        bool kör = true;
        while (kör==true)
        {
            Console.WriteLine("1. Är n ett primtal");
            Console.WriteLine("2. Antalet primtal mindre än n");
            Console.WriteLine("3. Avsluta programmet");
            string svar = Console.ReadLine();
            switch(svar)
            {
                case "1":
                    int x = int.Parse(Console.ReadLine());
                    Primtal1(x);
                    break;
                case "2":
                    Console.WriteLine("Skriv in ett heltal");
                    int tal = int.Parse(Console.ReadLine());
                    Console.WriteLine(Primtal2(tal) + " tal");
                    break;
                case "3":
                    kör = false;
                    break;
            }
        }
    }
    static int Primtal2(int svar)
    {
        int gånger = 0;
        for (int i = svar - 1; i > 0; i--)
        {
            if (i % 2 != 0)
            {
                gånger++;
            }
        }
        return gånger;
    }
    static void Primtal1(int x)
    {
        int gånger = 0;
        for (int i = 1; i < x; i++)
        {
            if (x % i == 0)
            {
                gånger++;
            }
        }
        if (gånger > 2 || x == 4)
        {
            Console.WriteLine(x + " är INTE ett primtal");
        }
        else
        {
            Console.WriteLine(x + " är ett primtal");
        }
    }
}
