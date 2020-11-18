using System;

namespace Uppgift_5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            Skapa ett program som innehåller en array som ska innehålla namnen på tre svenska städer. Skriv in två av namnen i programmets kod men låt användaren få skriva in namnet på den tredje staden. Skriv avslutningsvis ut alla stadsnamnen på samma rad.
            */

            // Skapa en array som ska innehålla namnen på tre svenska städer
            // Skriv in två av namnen i programmets kod
            string[] städer = {"Stockholm", "Paris", ""};

            // Låt användaren få skriva in namnet på den tredje staden
            System.Console.WriteLine("Ange en stad: ");
            städer[2] = Console.ReadLine();

            // Skriv avslutningsvis ut alla stadsnamnen på samma rad
            System.Console.WriteLine($"{städer[0]}, {städer[1]}, {städer[2]}");
        }
    }
}
