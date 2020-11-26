using System;

namespace Exempel_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Be om en text
            Console.Write("Ange en text: ");
            string text = Console.ReadLine();

            // Dela texten i separata ord
            string[] orden = text.Split(' ');

            // Loopa igenom arrayen
            /* for (int i = 0; i < orden.Length; i++)
            {
                Console.WriteLine($"Ord {i + 1}: {orden[i]}");
            } */

            // Alternativ 2 - foreach
            int i = 0;
            foreach (var ord in orden)
            {
                Console.WriteLine(ord);
                i++;
            }

            // Skriv ut antalet ord
            Console.WriteLine($"Antal ord {orden.Length}");
        }
    }
}
