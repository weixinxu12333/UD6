using System;
using System.Collections.Generic;
using System.Text;

namespace UF678_M3
{
    class Milstone1
    {
        public void Inici()
        {
            string c1, c2, c3, c4, c5, c6;
            c1 = EscriuNomCiutat();
            c2 = EscriuNomCiutat();
            c3 = EscriuNomCiutat();
            c4 = EscriuNomCiutat();
            c5 = EscriuNomCiutat();
            c6 = EscriuNomCiutat();

            ImprimirNomCiutat(c1);
            ImprimirNomCiutat(c2);
            ImprimirNomCiutat(c3);
            ImprimirNomCiutat(c4);
            ImprimirNomCiutat(c5);
            ImprimirNomCiutat(c6);

            string[] arrayCiutats = { c1, c2, c3, c4, c5, c6};
            Array.Sort(arrayCiutats);
            ImprimirArray(arrayCiutats);

        }

        public static string EscriuNomCiutat()
        {
            Console.WriteLine("Escriu nom de un ciutat: ");
            string ciutat = Console.ReadLine();
            return ciutat;
        }

        public static void ImprimirNomCiutat(string ciutat)
        {
            Console.WriteLine(ciutat);
        }

        public static void ImprimirArray(string[] array)
        {
            foreach (var i in array)
            {
                Console.WriteLine(i);
            }
        }
    }


}
