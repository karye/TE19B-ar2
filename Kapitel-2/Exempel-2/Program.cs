using System;

namespace Exempel_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Deklarera variabler
            string namn = "";
            int ålder = 0;
            int ålderÅr2025 = 0; // camelCase
            double längd = 1.5;
            string meddelande = "";

            // Läs in namnet
            Console.Write("Vad heter du? ");
            namn = Console.ReadLine();

            // Läs in längd i meter
            Console.Write("Hur lång är du? ");
            längd = double.Parse(Console.ReadLine());

            // Läs in ålder
            Console.Write("Hur gammal är du? ");
            ålder = int.Parse(Console.ReadLine());

            // Hur gammal är användaren år 2025
            ålderÅr2025 = ålder + 5;

            // Sammanställ resultatet
            meddelande = "Hej! " + namn + " du är " + längd + " m lång, och blir " + ålderÅr2025 + " år gammal 2025.";

            Console.WriteLine(meddelande);
        }
    }
}
