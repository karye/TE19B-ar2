using System;

namespace Argument
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length >= 2)
            {
                double summa = double.Parse(args[0]) + double.Parse(args[1]);
                Console.WriteLine("Summa = " + summa);
            } else
            {
                Console.WriteLine("Vg ange två argument.");
            }
        }
    }
}
