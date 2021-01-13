using System;

namespace SlumpBetyg
{
    class Program
    {
        static void Main(string[] args)
        {
            // Slumpa fram ett tal 0-5
            // Där 0 = F, 1 = E, 2 = D osv..
            // Skapa en slumpgenerator
            Random tärning = new Random();

            // Kasta tärningen
            int slumptal = tärning.Next(0, 8);
            Console.WriteLine($"Slumptalet = {slumptal}");

            // Skriv ut slumpade betyg
            // Alternativ 1
/*             if (slumptal == 0)
                Console.WriteLine("Du fick betyget F!");
            if (slumptal == 1)
                Console.WriteLine("Du fick betyget E!");
            if (slumptal == 2)
                Console.WriteLine("Du fick betyget D!");
            if (slumptal == 3)
                Console.WriteLine("Du fick betyget C!");
            if (slumptal == 4)
                Console.WriteLine("Du fick betyget B!");
            if (slumptal == 5)
                Console.WriteLine("Du fick betyget A!"); */

            // Alternativ 2
/*             switch (slumptal)
            {
                case 1:
                    Console.WriteLine("Du fick betyget E!");
                    break;
                case 2:
                    Console.WriteLine("Du fick betyget D!");
                    break;
                case 3:
                    Console.WriteLine("Du fick betyget C!");
                    break;
                case 4:
                    Console.WriteLine("Du fick betyget B!");
                    break;
                case 5:
                    Console.WriteLine("Du fick betyget A!");
                    break;

                default:
                    Console.WriteLine("Du fick betyget F!");
                    break;
            } */

            // Alternativ 3:
            string[] betyg = {"F", "E", "E", "E", "D", "C", "B", "A"};
            Console.WriteLine($"Du fick {betyg[slumptal]} i slutbetyg");
        }
    }
}
