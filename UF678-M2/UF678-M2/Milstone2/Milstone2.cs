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

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}
