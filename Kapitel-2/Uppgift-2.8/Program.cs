/* 
Skapa ett program där användaren på endast en rad ska 
skriva in en addition av två heltal som ska utföras. 
Användaren ska inte skriva några mellanslag, 
t.ex. kan hen skriva 4+3 eller 10+27. 
Beräkna svaret och skriv ut det.
 */

using System;

namespace Uppgift_2._8
{
    class Program
    {
        static void Main(string[] args)
        {
            // Läs in en addition tex "4+3"
            Console.Write("Ange en addition tex 4+3: ");
            string addition = Console.ReadLine();

            // Plocka ut talen
            int position = addition.IndexOf("+");
            int tal1 = int.Parse(addition.Substring(0, position));
            int tal2 = int.Parse(addition.Substring(position + 1));

            // Räkna ut summan
            int summa = tal1 + tal2;

            // Skriv ut svaret
            Console.WriteLine(addition + " = " + summa);
        }
    }
}
