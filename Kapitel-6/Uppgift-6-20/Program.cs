using System;

namespace Uppgift_6_20
{
    class Program
    {
        static void Main(string[] args)
        {
            while (menyVal != "3")
            {
                Console.WriteLine("1. Addera tre tal");
                Console.WriteLine("2. Största talet av två tal");
                Console.WriteLine("3. Avsluta programmet");
                menyVal = Console.ReadLine();

                switch (menyVal)
                {
                    case "1":
                        MenyvalAddera();
                        break;
                    case "2":
                        MenyvalStörstaTalet();
                        break;
                    case "3":
                        Console.WriteLine("Tack för idag!");
                        break;

                    default:
                        Console.WriteLine("Felaktigt val! Vg försök igen!");
                        break;
                }
            }
        }

        static void MenyvalAddera()
        {
            int tal1 = int.Parse(Console.ReadLine());
            int tal2 = int.Parse(Console.ReadLine());
            int tal3 = int.Parse(Console.ReadLine());
            Console.WriteLine(Addera(tal1, tal2, tal3));
        }

        static void MenyvalStörstaTalet()
        {
            int tal1 = int.Parse(Console.ReadLine());
            int tal2 = int.Parse(Console.ReadLine());
            Console.WriteLine(StörstaTalet(tal1, tal2));
        }

        static int Addera(int tal1, int tal2, int tal3)
        {
            return tal1 + tal2 + tal3;
        }

        static int StörstaTalet(int tal1, int tal2)
        {
            if (tal1 > tal2)
            {
                return tal1;
            } else
            {
                return tal2;
            }
        }
    }
}
