using System;
using System.IO;

namespace Filhantering
{
    class Program
    {
        static void Main(string[] args)
        {
            // Skriva till en textfil
            File.WriteAllText("fil1.txt", "Nu snöar det igen! Kul!");

            // Läsa innehållet av en textfil
            string allText = File.ReadAllText("./Filhantering.csproj");

            // Skriv ut innehållet
            Console.WriteLine($"Innehållet: \n{allText}");

            // Fråga användaren om filnamn
            Console.Write("Ange filnamn: ");
            string filnamn = Console.ReadLine();

            // Kontrollera att filen finns!
            if (File.Exists(filnamn))
            {
                // Läs in allt
                string texten = File.ReadAllText(filnamn);
                Console.WriteLine(texten);
            } else
            {
                Console.WriteLine($"Hittade inte filen \"{filnamn}\"");
            }
        }
    }
}
