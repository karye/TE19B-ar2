/* 
Skapa ett program som frågar användaren efter två tal. Programmet ska sedan beräkna och skriva ut summan av talen och därefter produkten av talen.
 */
using System;

namespace Uppgift_2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Läs in första argumentet
            int tal1 = int.Parse(args[0]);

            // Läs in andra argumentet
            int tal2 = int.Parse(args[1]);

            // Räkna ut summan och skriv ut
            int summa = tal1 + tal2;
            Console.WriteLine("Summan = " + summa);

            // Räkna ut produkten och skriv ut
            int produkt = tal1 * tal2;
            Console.WriteLine("Produkten = " + produkt);

/*             // Läs in ett heltal
            Console.Write("Ange tal1: ");
            int tal1 = int.Parse(Console.ReadLine());

            // Läs in ett heltal till
            Console.Write("Ange tal2: ");
            int tal2 = int.Parse(Console.ReadLine());

            // Räkna ut summan och skriv ut
            int summa = tal1 + tal2;
            Console.WriteLine("Summan = " + summa);

            // Räkna ut produkten och skriv ut
            int produkt = tal1 * tal2;
            Console.WriteLine("Produkten = " + produkt); */
        }
    }
}
