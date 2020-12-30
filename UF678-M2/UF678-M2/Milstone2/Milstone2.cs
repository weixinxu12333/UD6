using System;
using System.Collections.Generic;
using System.Text;

namespace UF678_M2
{
    class Milstone2
    {
        public void Inicio()
        {
            Console.WriteLine("Escriu un nombre:");
            int n = Convert.ToInt32(Console.ReadLine());
            ImprimirNumeros(n);

            Console.WriteLine("Escriu un nombre per piramide:");
            int n2 = Convert.ToInt32(Console.ReadLine());
            ImprimirPiramide(n);
        }

        public static void ImprimirNumeros(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }

        public static void ImprimirPiramide(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= (n*2 - (i*2-1)) ; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
