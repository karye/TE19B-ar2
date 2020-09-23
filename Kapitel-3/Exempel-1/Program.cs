using System;

namespace Exempel_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Läs in ålder
            Console.WriteLine("Hur gammal är du? (Svara i hela antal år) ");
            int ålder = int.Parse(Console.ReadLine());

            // Om ålder = 18 skriv myndig
            if (ålder >= 18)
            {
                Console.WriteLine("Du är myndig. Du får ta körkort.");
            }

            // Om åldre är 15 eller högre
            if (ålder >= 15)
            {
                Console.WriteLine("Du får köra moped!");
            }

            // Om åldern lägre än 15, skriv du är för ung för ...
            if (ålder < 15)
            {
                Console.WriteLine("Du är för ung!");
            }

            // Läs in en text, (Palme)
            Console.Write("Vem var statsminister i Sverige 1970? ");
            string statsminister = Console.ReadLine();
            /* if (statsminister == "Palme" || statsminister == "palme")
            {
                Console.WriteLine("Rätt svar!");
            } */

            // Sanera inmatningen
            statsminister = statsminister.ToLower();
            if (statsminister == "palme")
            {
                Console.WriteLine("Rätt svar!");
            }
            else {
                Console.WriteLine("Fel svar!");
            }
        }
    }
}
