using System;

namespace Exempel_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Slumpa fran ett tal 1-6
            Random tärning = new Random();
            int slumptal = tärning.Next(1, 7);

            // Upprepa tills rätt svar gissats
            while (true)
            {
                // Läs in användarens gissning
                Console.WriteLine("Gissa ett tal (1-6) ?");
                int gissning = int.Parse(Console.ReadLine());

                // Om användaren gissat rätt?
                if (gissning == slumptal)
                {
                    Console.WriteLine("Rätt gissat!");
                    break;
                }
                else
                {
                    Console.WriteLine("Fel gissat! Försök igen!");
                }
            }

            // Slut
            Console.WriteLine("Tack för idag!");
        }
    }
}
