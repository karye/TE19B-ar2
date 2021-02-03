using System;
using System.IO;

namespace Projekt_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Deklarera variabler och initialisera
            int antalBord = 8;
            string filnamn = "centralbord.csv";
            string tomtBordBeskrivning = "0,Inga gäster";
            string[] bordsInformation; // Array för att lagra bokningar

            // Presentera programmet för användaren
            Console.WriteLine("Detta är Centralrestaurangens bordhanterare");

            // Finns lagrinsfilen?
            if (File.Exists(filnamn))
            {
                // Läs in alla rader, dvs bordsbokningar
                bordsInformation = File.ReadAllLines(filnamn);
                Console.WriteLine("Bordsbokningar lästes in från fil");
            }
            else
            {
                // Skapa en tom bordslista i arrayen
                // Lagra detta i filen
                bordsInformation = new string[antalBord];   // 8 nya tomma positioner

                // Fyll arrayen med tomma bord: 0, 1, 2, 3, 4, 5, 6, 7
                for (int i = 0; i < antalBord; i++)
                {
                    bordsInformation[i] = tomtBordBeskrivning;
                }

                // Lagra i filen
                File.WriteAllLines(filnamn, bordsInformation);
                Console.WriteLine("Fil med bordsinformation saknas, ny fil skapades");
            }

            // Huvudloopen
            while (true)
            {
                // Skriv ut huvudmenyn
                Console.WriteLine("Välj ett alternativ");
                Console.WriteLine("1. Visa alla bord");
                Console.WriteLine("2. Lägg till/ändra bordsinformation");
                Console.WriteLine("3. Markera bord tomt");
                Console.WriteLine("4. Avsluta");
                string menyVal = Console.ReadLine();

                // Hantera menyval
                switch (menyVal)
                {
                    // Visa alla bord
                    case "1":
                        int totaltAntalGäster = 0;
                        for (int i = 0; i < antalBord; i++)
                        {
                            if (bordsInformation[i] == tomtBordBeskrivning)
                            {
                                // Bordet är tomt
                                Console.WriteLine($"Bord {i + 1} - Inga gäster");
                            } else
                            {
                                // Bordet har en bokning
                                // Plocka namn och antal gäster
                                string[] delar = bordsInformation[i].Split(',');
                                string antalGäster = delar[0];
                                string namn = delar[1];

                                // Summera alla gäster
                                totaltAntalGäster += int.Parse(antalGäster);

                                // Skriv ut bokningsinfo
                                Console.WriteLine($"Bord {i + 1} - Namn: {namn}, antal gäster: {antalGäster}");
                            }
                        }

                        // Summera
                        Console.WriteLine($"Total antal gäster: {totaltAntalGäster}");
                        break;

                    case "2":
                        break;

                    case "3":
                        break;

                    case "4":
                        break;
                    
                    default:
                        Console.WriteLine("Du valde inte ett giltigt alternativ");
                        break;
                }
            }
        }
    }
}
