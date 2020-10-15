using System;

namespace Exempel_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Slumpa fram ett tal (1-6)
            Random tärning = new Random();
            int slumptal = tärning.Next(1, 7);

            // Deklarera variabeln gissning
            int gissning = 0;

            // Loopar tills vi får rätt svar
            while (gissning != slumptal)
            {
                // Fråga anvädaren vad hen gissar
                Console.WriteLine("Gissa ett tal (1-6)? ");

                // Läs in användarens gissning
                //gissning = int.Parse(Console.ReadLine());

                // En säkrare inmattning
                string input = Console.ReadLine();

                // Försöker översätta till ett heltal
                if (int.TryParse(input, out gissning))
                {
                    Console.WriteLine("Vad bra att du matade in ett tal!");

                    // Kolla om gissningen är fel
                    if (gissning != slumptal)
                    {
                        Console.WriteLine("Fel svar! Försök igen!");
                    }
                }
                else
                {
                    Console.WriteLine("Nej! Jag bad om ett tal! Försök igen!");
                }

            }

            // Rätt svar!
            Console.WriteLine("Rätt svar!");
        }
    }
}
