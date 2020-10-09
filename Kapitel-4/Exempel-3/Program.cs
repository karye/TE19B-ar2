using System;

namespace Exempel_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // För att loopa 10 ggr
            int i = 10;
            while (i > 0)
            {
                Console.WriteLine(i);
                i--; // i = i - 1; Räkna med 1
            }

            // En variabel som tar emot det användaren skriver
            string name = "";

            // Körs så många gånger som behövs för att 
            // användaren ska förstå att hen ska skriva "Micke"
            while (name != "Micke") // Så länge name inte lika med "Micke"
            {
                Console.WriteLine("Skriv ditt namn:")
                name = Console.ReadLine();
            }
        }
    }
}
