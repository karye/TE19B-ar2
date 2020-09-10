/* 
Skapa ett program som frågar användaren hur högt hen kan hoppa i höjdhopp mätt i meter. Berätta för användaren hur mycket högre världsrekordet i höjdhopp är (världsrekordet i höjdhopp är 2,45 meter).
 */

using System;

namespace Uppgift_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Läs in längden
            Console.Write("Hur högt hoppar du? ");
            double minLängd = double.Parse(Console.ReadLine());

            // Räkna ut skillnad till världsrekord
            double skillnad = Math.Round(2.45 - minLängd, 2);

            Console.WriteLine("Du är " + skillnad + " från världsrekordet i höjhopp 2,45 m.");
        }
    }
}
