using System;

namespace GissaEttTal
{
    class Program
    {
        static void Main(string[] args)
        {
            // Slumpa fram ett heltal 1-6
            Random slump = new Random();
            int slumptal = slump.Next(1, 7);

            // Fråga fem gånger
            for (int i = 0; i < 5; i++) // i++ = i + 1
            {
                // Läs in en gissning
                Console.Write("Gissa ett tal (1-6)? ");
                int gissning = int.Parse(Console.ReadLine());

                // Kolla om gissningen är korrekt
                if (gissning == slumptal)
                {
                    Console.WriteLine("Rätt svar!");
                    i = 5; // Knep för avsluta loopen!
                }
                else
                {
                    Console.WriteLine("Fel svar!");
                }
            }
        }
    }
}
