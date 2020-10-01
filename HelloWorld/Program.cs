using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Min första textrad!");

            // Slumpa fram 0 eller 1
            Random rnd = new Random();
            int slumpat = rnd.Next(2);
            if (slumpat == 0)
            {
                Console.WriteLine("Programmet har kraschat!");
            } else
            {
                Console.WriteLine("Du kunde landade!");
            }

        }
    }
}
