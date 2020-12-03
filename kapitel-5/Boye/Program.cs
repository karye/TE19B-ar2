using System;

namespace Boye
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lagra en dikt i en array
            string[] dikt = {
                "Den mätta dagen, den är aldrig störst.",       // 0
                "Den bästa dagen är en dag av törst.",          // 1

                "Nog finns det mål och mening i vår färd -",    // 2
                "men det är vägen, som är mödan värd.",         // 3

                "Det bästa målet är en nattlång rast,",         // 4
                "där elden tänds och brödet bryts i hast.",     // 5

                "På ställen, där man sover blott en gång,",     // 6
                "blir sömnen trygg och drömmen full av sång.",  // 7
                
                "Bryt upp, bryt upp! Den nya dagen gryr.",      // 8
                "Oändligt är vårt stora äventyr."               // 9
            };

            // Skriv ut dikten
            // Loopa igenom arrayen
            /* foreach (var rad in dikt)
            {
                System.Console.WriteLine(rad);
            } */

            // Skriv som verser
            // Loopar igenom arrayen
            int totalAntalOrd = 0;
            for (int i = 0; i < dikt.Length; i++)
            {
                // Om delbart med 2, dvs jämn rad
                if (i % 2 == 0)
                {
                    // Jämnt: skriv ut raden
                    System.Console.WriteLine(dikt[i]);
                }
                else
                {
                    // Udda: skriv ut raden + en tom rad
                    System.Console.WriteLine(dikt[i] + "\n");
                }

                // Dela upp raden i en array av ord
                string[] orden = dikt[i].Split(' ');
                // Räkna orden: antal ord i arrayen
                int antalOrd = orden.Length;

                // Addera till total antal ord
                totalAntalOrd += antalOrd;
            }

            // Antal ord i dikten
            System.Console.WriteLine($"Antal ord i dikten är {totalAntalOrd}");
        }
    }
}
