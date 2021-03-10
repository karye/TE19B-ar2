﻿using System;

namespace Uppgift6._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur stor ska rätvinklig triangeln vara?");
            int sidLängd = int.Parse(Console.ReadLine());
            RitaRätvinkligTriangel(sidLängd);
        }
        static void RitaRätvinkligTriangel(int längd)
        {
            for (int i = 0; i > längd; i++)
            {
                System.Console.WriteLine("*");
            }
        }
    }
}