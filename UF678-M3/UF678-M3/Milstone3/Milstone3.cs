using System;
using System.Collections.Generic;
using System.Text;

namespace UF678_M3
{
    class Milstone3
    {
        public void Inicio()
        {
            Console.WriteLine("Quants numeros de la sequencia de Fibonacci vols?");
            int num = Convert.ToInt32(Console.ReadLine());
            foreach (ulong i in new Fibonacci(num))
                Console.WriteLine(i);
        }
    }
}
