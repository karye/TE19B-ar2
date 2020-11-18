using System;

namespace Uppgift_5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            Skapa ett program där användaren ska få skriva in en lista över alla sporter som hen har testat. Fråga först användaren hur många sporter hen vill skriva in. Därefter ska sporterna skrivas in, en efter en, på var sin rad. Slutligen ska programmet skriva ut namnen på alla sporterna som användaren skrev in.
            */

            // Fråga först användaren hur många sporter hen vill skriva in
            Console.Write("Hur många sporter vill du skriva in? ");
            int antal = int.Parse(Console.ReadLine());

            // Skapa en array av sporter
            string[] sporter = new string[antal];

            // Därefter ska sporterna skrivas in, en efter en, på var sin rad
            Console.WriteLine("Skriv in dina sporter: ");
            for (int i = 0; i < antal; i++)
            {
                sporter[i] = Console.ReadLine();
            }

            // Slutligen ska programmet skriva ut namnen på alla sporterna
            for (int i = 0; i < antal; i++)
            {
                Console.WriteLine(sporter[i]);
            }
        }
    }
}
