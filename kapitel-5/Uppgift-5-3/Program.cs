using System;

namespace Uppgift_5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            Skapa ett program som innehåller en array med minst 8 heltal. Gå igenom arrayen med hjälp av en loop och hitta det största talet i arrayen.
            */

            // Skapa en array med minst 8 heltal
            int[] talen = {9, 45, 12, 56, 8, 98, 123, 75, 1, 46};

            // Skapa en variabel som skall innehålla max-värdet
            int max = 0;

            // Gå igenom arrayen med hjälp av en loop
            for (int i = 0; i < talen.Length; i++)
            {
                // hitta det största talet i arrayen
                if (talen[i] > max)
                {
                    max = talen[i];
                }
            }

            Console.WriteLine($"Största talet är {max}");
        }
    }
}
