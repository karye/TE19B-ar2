using System;
using System.IO;

namespace Countries
{
    class Program
    {
        static void Main(string[] args)
        {
            // Presentera programmet
            Console.WriteLine("Program för att hitta länder matchande sökterm.");
            Console.WriteLine("Program listar land och landskod.");

            // @todo skapa variabel för filnamn

            // Läser in alla rader i textfilen, om den finns
            if (File.Exists("countries.csv"))
            {
                // Läser in alla rader
                string[] rader = File.ReadAllLines("countries.csv");

                // Ber användaren om sökterm
                Console.Write("Ange sökterm (avsluta med return): ");
                string sökterm = Console.ReadLine();

                // Loopa igenom alla rader
                foreach (var rad in rader)
                {
                    // Söka i den röda fältet
                    //Console.WriteLine(rad);   // rad är en string
                    string[] delar = rad.Split(',');

                }
            } else
            {
                Console.WriteLine("Avbryter! Filen countries.csv finns inte.");
            }
        }
    }
}
