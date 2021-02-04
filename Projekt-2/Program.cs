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
            string menyVal = "";
            while (menyVal != "4")
            {
                // Skriv ut huvudmenyn
                Console.WriteLine("Välj ett alternativ");
                Console.WriteLine("1. Visa alla bord");
                Console.WriteLine("2. Lägg till/ändra bordsinformation");
                Console.WriteLine("3. Markera bord tomt");
                Console.WriteLine("4. Avsluta");
                menyVal = Console.ReadLine();

                // Hantera menyval
                string antalGäster = "";
                string bordNamn = "";
                string bordNr = "";
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
                                antalGäster = delar[0];
                                bordNamn = delar[1];

                                // Summera alla gäster
                                totaltAntalGäster += int.Parse(antalGäster);

                                // Skriv ut bokningsinfo
                                Console.WriteLine($"Bord {i + 1} - Namn: {bordNamn}, antal gäster: {antalGäster}");
                            }
                        }

                        // Summera
                        Console.WriteLine($"Total antal gäster: {totaltAntalGäster}");
                        break;

                    case "2":
                        // Fråga bordsnr
                        Console.WriteLine("Vilket bord vill du ändra på?");

                        // Kontrollera att man matar bord 1-8
                        while (true)
                        {
                            bordNr = Console.ReadLine();
                            if (int.Parse(bordNr) <= 0 || int.Parse(bordNr) > antalBord)
                            {
                                Console.WriteLine("Icke giltigt bordsnummer, vg försök igen");
                            } else
                            {
                                break;
                            }
                        }
                        // @todo hantera inmatningsfel med tryParse()

                        // Fråga namn
                        Console.WriteLine("Ange ett namn");
                        bordNamn = Console.ReadLine();

                        // Fråga antal gäster
                        Console.WriteLine("Ange antal gäster?");
                        antalGäster = Console.ReadLine();
                        // @todo Vad händer om man matar fel antal gäster

                        // Spara i arrayen
                        bordsInformation[int.Parse(bordNr) - 1] = $"{antalGäster},{bordNamn}";

                        // Lagra i filen
                        File.WriteAllLines(filnamn, bordsInformation);

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
