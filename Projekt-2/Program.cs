﻿using System;
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

            // Format: antal gäster, namn, nota
            string tomtBordBeskrivning = "0,Inga gäster,0";

            // Array för att lagra bokningar
            string[] bordsInformation; 

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
            while (menyVal != "5")
            {
                // Skriv ut huvudmenyn
                Console.WriteLine("Välj ett alternativ");
                Console.WriteLine("1. Visa alla bord");
                Console.WriteLine("2. Lägg till/ändra bordsinformation");
                Console.WriteLine("3. Markera bord tomt");
                Console.WriteLine("4. Öka nota");
                Console.WriteLine("5. Avsluta");
                menyVal = Console.ReadLine();

                // Hantera menyval
                string bordNamn = "";
                int svar = 0, bordNr = 0, antalGäster = 0, nota = 0;
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
                            }
                            else
                            {
                                // Bordet har en bokning
                                // Plocka ut namn och antal gäster
                                string[] delar = bordsInformation[i].Split(',');
                                string antalGästerString = delar[0];
                                bordNamn = delar[1];
                                string notaString = delar[2];

                                // Summera alla gäster
                                totaltAntalGäster += int.Parse(antalGästerString);

                                // Skriv ut bokningsinfo
                                Console.WriteLine($"Bord {i + 1} - Namn: {bordNamn}, antal gäster: {antalGästerString}, nota: {notaString}");
                            }
                        }

                        // Summera
                        Console.WriteLine($"Total antal gäster: {totaltAntalGäster}");
                        break;

                    // Boka bord
                    case "2":
                        // Fråga bordsnr
                        Console.WriteLine("Vilket bord vill du ändra på?");
                        while (!int.TryParse(Console.ReadLine(), out svar) || svar < 1 || svar > 8)
                        {
                            Console.WriteLine("Icke giltigt bordsnummer, vg försök igen");
                        }
                        bordNr = svar;

                        // Fråga namn
                        Console.WriteLine("Ange ett namn");
                        bordNamn = Console.ReadLine();

                        // Fråga antal gäster
                        Console.WriteLine("Ange antal gäster?");
                        while (!int.TryParse(Console.ReadLine(), out svar) && svar <= 1 || svar > 8) // @todo bugg
                        {
                            Console.WriteLine("Icke giltigt bordsnummer, vg försök igen");
                        }
                        antalGäster = svar;

                        // Spara i arrayen
                        bordsInformation[bordNr - 1] = $"{antalGäster},{bordNamn}"; // @todo bugg

                        // Lagra i filen
                        File.WriteAllLines(filnamn, bordsInformation);
                        break;

                    // Makera bord tomt
                    case "3":
                        // Fråga bordsnr
                        Console.WriteLine("Vilket bord vill du ändra på?");

                        // Kontrollera att man matar bord 1-8
                        while (!int.TryParse(Console.ReadLine(), out svar) && svar <= 1 || svar > 8) // @todo bugg
                        {
                            Console.WriteLine("Icke giltigt bordsnummer, vg försök igen");
                        }
                        bordNr = svar;

                        // Återställ bordets info till tomt
                        bordsInformation[bordNr - 1] = tomtBordBeskrivning;

                        // Uppdatera filen
                        File.WriteAllLines(filnamn, bordsInformation);
                        break;

                    // Öka nota
                    case "4":
                        // Fråga bordsnr
                        Console.WriteLine("Vilket bord vill du ändra på?");
                        while (!int.TryParse(Console.ReadLine(), out svar) && svar <= 1 || svar > 8) // @todo bugg
                        {
                            Console.WriteLine("Icke giltigt bordsnummer, vg försök igen");
                        }
                        bordNr = svar;

                        // Fråga öka nota
                        Console.WriteLine("Hur mycket vill du öka notan?");
                        while (!int.TryParse(Console.ReadLine(), out svar) && svar <= 1)    // @todo finns den övre gräns?
                        {
                            Console.WriteLine("Icke giltigt bordsnummer, vg försök igen");
                        }
                        nota = svar;

                        // Spara i arrayen
                        bordsInformation[bordNr - 1] = $"{antalGäster},{bordNamn},{nota}";

                        // Lagra i filen
                        File.WriteAllLines(filnamn, bordsInformation);
                        break;

                    // Avsluta programmet
                    case "5":
                        break;

                    default:
                        Console.WriteLine("Du valde inte ett giltigt alternativ");
                        break;
                }
            }
        }
    }
}
