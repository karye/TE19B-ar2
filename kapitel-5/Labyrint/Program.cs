using System;
namespace Labyrint
{
    class Program
    {
        static void Main(string[] args)
        {
            // För att skriva ut Entities
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            // Slumpa fram in en tomte i labyrinten
            Random slumpMotor = new Random();

            // Skapa en labyrint
            int[,] labyrint = {
                {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},  // 0
                {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},  // 1
                {1, 0, 1, 1, 1, 0, 1, 0, 1, 0, 1},  // 2
                {1, 0, 1, 1, 0, 0, 1, 0, 1, 0, 1},  // 3
                {1, 0, 1, 1, 0, 1, 1, 0, 0, 0, 1},  // 4
                {1, 0, 0, 0, 0, 0, 1, 1, 0, 1, 1},  // 5
                {1, 0, 1, 0, 1, 0, 0, 1, 0, 1, 1},  // 6
                {1, 0, 1, 0, 1, 1, 0, 1, 0, 1, 1},  // 7
                {1, 0, 1, 0, 0, 0, 0, 0, 0, 1, 1},  // 8
                {1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1}   // 9
            };

            // Vart spelaren är
            int spelarePosY = 9;
            int spelarePosX = 1;
            int poäng = 0;
            int antalTomtar = 3;

            while (antalTomtar != 0)
            {
                // Slumpa fram koordinater
                int x = slumpMotor.Next(0, 11);  // 0-6
                int y = slumpMotor.Next(0, 10);  // 0-6

                // Hamnar vi i en gång
                if (labyrint[y, x] == 0)
                {
                    labyrint[y, x] = 2;
                    antalTomtar--;
                }
            }

            // Spelloopen
            while (true)
            {
                // Infoga spelaren i labyrinten
                labyrint[spelarePosY, spelarePosX] = 3;

                // Skriva ut labyrinten
                // Loopa igenom rad för rad, dvs i y-led
                Console.Clear();
                for (int y = 0; y < 10; y++)
                {
                    // Loopa igenom kolumnvis, dvs x-led
                    for (int x = 0; x < 11; x++)
                    {
                        switch (labyrint[y, x])
                        {
                            case 1: // En vägg
                                Console.Write('\u2B1C');
                                break;

                            case 2: // En tomte
                                Console.Write("🎅");
                                break;

                            case 3: // En spelare
                                Console.Write("😀");
                                break;

                            default: // En gång
                                Console.Write('\u2B1B');
                                break;
                        }
                    }
                    Console.WriteLine();
                }

                // Fråga spelare vart hen vill gå?
                Console.Write($"Poäng: {poäng}\nVart vill du gå? (A/D/W/S)");
                string riktning = Console.ReadLine().ToUpper().Substring(0, 1);

                labyrint[spelarePosY, spelarePosX] = 0;
                switch (riktning)
                {
                    case "A": // x--
                    if (labyrint[spelarePosY, spelarePosX - 1] != 1)
                    {
                        spelarePosX--;
                    }
                    break;

                    case "D": // x++
                    if (labyrint[spelarePosY, spelarePosX + 1] != 1)
                    {
                        spelarePosX++;
                    }
                    break;

                    case "W": // y--
                    if (labyrint[spelarePosY - 1, spelarePosX] != 1)
                    {
                        spelarePosY--;
                    }
                    break;

                    case "S": // y++
                    if (spelarePosY < 9 && labyrint[spelarePosY + 1, spelarePosX] != 1)
                    {
                        spelarePosY++;
                    }
                    break;

                    default:
                    Console.WriteLine("Förstod inte ditt kommando. Försök igen!");
                    break;
                }
                if (labyrint[spelarePosY, spelarePosX] == 2)
                {
                    poäng++;
                }
            }
        }
    }
}