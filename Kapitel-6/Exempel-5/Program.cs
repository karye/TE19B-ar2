using System;

namespace Exempel_5
{
    class Program
    {
        // En klassvariabel
        static string respons = "Du skrev inte ett heltal, vg försök igen";

        // Ett bra exempel på klassvariabel
        static Random slump = new Random();

        static void Main(string[] args)
        {
            Console.WriteLine("Ange ett heltal");
            int tal = ReadInt();
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
                Console.WriteLine(respons);
            }
            return svar;
        }
    }
}
