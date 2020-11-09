using System;

namespace Uppgift_4_11
{
    class Program
    {
        static void Main(string[] args)
        {
            // Fråga användaren vilket är Europas folkrikaste land
            Console.Write("Vilket är Europas folkrikaste land? ");
            string svar = Console.ReadLine();

            // Sanering av input
            svar = svar.ToLower();

            // Loopa som mest 5 ggr
            // Fråga användaren om svaret
            for (int i = 0; i < 4; i++)
            {
                // Är det rätt svar? Isåfall avbryt
                if (svar == "tyskland")
                {
                    Console.WriteLine("Bravo! Rätt svar.");
                    break;
                }
                else
                {
                    Console.Write("Försök igen: ");
                    svar = Console.ReadLine();
                }
            }
        }
    }
}
