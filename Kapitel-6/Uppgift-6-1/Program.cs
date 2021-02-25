using System;

namespace Uppgift_6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            TalIKvadrat(3);
            TalIKvadrat(4);
            TalIKvadrat(5);
        }

        // Metod för att skriva tal och tal i kvadrat
        static void TalIKvadrat(int tal) {
            Console.WriteLine($"Talet {tal} i kvadrat är {tal * tal}");
        }
    }
}
