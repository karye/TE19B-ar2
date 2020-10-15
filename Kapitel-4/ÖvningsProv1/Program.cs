using System;

namespace ÖvningsProv1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Deklarera variabler
            int poäng = 0;
            int gissning = 0;
            string gissningText = "";
            //bool lyckades = false;
            int flagga = 0;

            // Ställa frågan
            Console.WriteLine("Vad är x i formeln x * 6 = 42?");

            // Läs in användarens svar tills hen matar in ett tal
            while (flagga == 0)
            {
                // Läs in det användaren skriver
                gissningText = Console.ReadLine();

                // Är det ett tal eller inte?
                // Blir true eller false
                if (int.TryParse(gissningText, out gissning))
                {
                    flagga = 1;
                }
                else
                {
                    // Varnar användaren om hen inte matat in ett tal
                    Console.WriteLine("Fel! Vg mata in ett tal.");
                }

            }

            // Kolla om gissningen är korrekt eller inte
            if (gissning == 7)
            {
                poäng++;
                Console.WriteLine($"Korrekt svar! Du har {poäng} poäng.");
            }
            else
            {
                Console.WriteLine("Fel svar!");
            }
        }
    }
}
