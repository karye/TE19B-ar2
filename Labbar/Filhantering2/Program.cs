using System;
using System.IO;

namespace Filhantering2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Filnamnet
            string filnamn = "./animals.txt";

            // Läs in alla rader
            string[] rader = File.ReadAllLines(filnamn);

            // Läs in sökterm
            Console.Write("Ange sökterm (första boktaven): ");
            string sökterm = Console.ReadLine();

            // Loopa igenom arrayen
            // Dvs gå igenom rad-för-rad
            int radNr = 1;
            foreach (var rad in rader)
            {
                // Kolla om första bokstaven = sökterm
                if (rad.Substring(0, 1) == sökterm)
                {
                    Console.WriteLine($"{radNr}\t{rad}");
                    radNr++;
                }
            }

            // Antal hittade rader
            Console.WriteLine($"Antal djur {radNr - 1}");
        }
    }
}
