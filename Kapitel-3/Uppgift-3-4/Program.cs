/* 
På det nationella provet i Matematik 4 våren 2013 så fanns följande poänggränser för olika provbetyg.
 */

using System;

namespace Uppgift_3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Läs in poäng
            Console.Write("Hur många poäng fick du på provet ? ");
            int poäng = int.Parse(Console.ReadLine());

            // Skriv ut betyg
            if (poäng >= 55)
            {
                Console.WriteLine("DU fick betyget A");
            }
            else if (poäng >= 46)
            {
                Console.WriteLine("DU fick betyget B");
            }
            else if (poäng >= 35)
            {
                Console.WriteLine("DU fick betyget C");
            }
            else if (poäng >= 27)
            {
                Console.WriteLine("DU fick betyget D");
            }
            else if (poäng >= 18)
            {
                Console.WriteLine("DU fick betyget E");
            }
            else
            {
                Console.WriteLine("DU fick betyget F");
            }
        }
    }
}
