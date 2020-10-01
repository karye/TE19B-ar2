/* 
Skapa ett program som frågar användaren vilket land som vann fotbolls-VM för damer år 2015. Om användaren svarar USA ska programmet skriva ut att svaret var rätt, annars ska programmet skriva ut att svaret var fel. Det ska inte spela någon roll om användaren skriver svaret med stora eller små bokstäver.
 */

using System;

namespace Uppgift_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Läs in en text (Usa)
            Console.Write("Vem vann fotbolls-VM för damer 2015 ? ");
            string vinnare = Console.ReadLine();

            // Sanera inmatningen
            vinnare = vinnare.ToLower();

            // Kontrollera om rätt svar
            if (vinnare == "usa")
            {
                Console.WriteLine("Rätt svar!");
            }
            else {
                Console.WriteLine("Fel svar!");
            }
        }
    }
}
