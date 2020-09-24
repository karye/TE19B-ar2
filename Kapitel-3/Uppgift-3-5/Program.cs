/* 
För att få åka en viss berg-och-dalbana på en nöjespark så måste man vara mellan 1,5 och 1,9 meter lång. Skapa ett program som frågar användaren hur lång hen är och sedan skriver ut om hen får åka berg-och-dalbanan eller inte.
 */

using System;

namespace Uppgift_3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Läsa in längd
            Console.Write("Hur lång är du? ");
            double längd = double.Parse(Console.ReadLine());

            // Svara med om man får eller inte åka
            if (1.5 < längd && längd < 1.9)
            {
                Console.WriteLine("Du får åka berg-och-dalbana!");
            }
            else
            {
                Console.WriteLine("Du får tyvärr inte åka!");
            }
        }
    }
}
