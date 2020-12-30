using System;
using System.Collections.Generic;
using System.Text;

namespace UF678_M1
{
    class Milstone2
    {
        public void inicio()
        {
            double num = 12.34;
            int i = (int)num;
            float f = (float)num;
            string s = Convert.ToString(num);

            Imprimir(num, i, f, s);

        }

        public static void Imprimir(double num, int i, float f, string s)
        {
            Console.WriteLine("double: " + num);
            Console.WriteLine("int: " + i);
            Console.WriteLine("float: " + f);
            Console.WriteLine("string: " + s);

        }
    }
}
