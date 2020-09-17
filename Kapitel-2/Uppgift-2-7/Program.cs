/* 
Skapa ett program där användaren får skriva in en mening 
(utan punkt) som består av två ord. 
Skriv ut orden till användaren i omvänd ordning.
 */
using System;

namespace Uppgift_2_7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Läs in texten
            Console.Write("Ange två ord med mellanslag emellan: ");
            string texten = Console.ReadLine();

            // Dela upp texten
            int position = texten.IndexOf(" ");
            string ordFöre = texten.Substring(0, position);
            string ordEfter = texten.Substring(position + 1);

            // Skriv ut i omvänd ordning
            Console.WriteLine(ordEfter + " " + ordFöre);
        }
    }
}
