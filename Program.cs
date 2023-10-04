using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_ejercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Divisores de Juan David:");
            Console.WriteLine("=============================");

            for (int i = 1; i <= 1000; i++) {

                if (i % 3 == 0) {

                    Console.WriteLine("Divisor de Juan David " + (i / 3) + ": " + i);
                }
            }
            Console.ReadKey();
        }
    }
}
