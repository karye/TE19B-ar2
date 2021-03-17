using System;
using System.IO;

namespace Exempel_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Osäker metod att konvertera till int
            int talet = int.Parse(Console.ReadLine());

            // Be om ett heltal
            //Console.WriteLine("Ange ett tal 1-100");
            //int.TryParse(Console.ReadLine())

            Console.WriteLine("Vilket bord vill du ändra på?");
            int bordNr = ReadInt();
            Console.WriteLine($"Du valde bord {bordNr}");
        }

        /// <summary>
        /// Metoden för säkert sätt att läsa in heltal
        /// </summary>
        /// <returns>Heltalet</returns>
        static int ReadInt()
        {
            int svar = 0;
            while (!int.TryParse(Console.ReadLine(), out svar))   // ! == false
            {
                Console.WriteLine("Du skrev inte ett heltal, vg försök igen");
            }
            return svar;
        }
    }
}
