using System;
using System.Collections.Generic;
using System.Text;

namespace UF678_M3
{
    class Milstone1
    {
        public void Inici()
        {
            Console.WriteLine("----------Fase 1----------");
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

            Console.WriteLine("----------Fase 2----------");
            string[] arrayCiutats = { c1, c2, c3, c4, c5, c6 };
            Array.Sort(arrayCiutats);
            ImprimirArray(arrayCiutats);

            Console.WriteLine("----------Fase 3----------");
            string[] ArrayCiutatsModificades = new string[arrayCiutats.Length];
            ArrayCiutatsModificades = ModificarLleta(arrayCiutats, 'a');
            Array.Sort(ArrayCiutatsModificades);
            ImprimirArray(ArrayCiutatsModificades);


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

        public static string[] ModificarLleta(string[] arr, char lletra)
        {
            string[] ArrayCiutatsModificades = new string[6];
            string ciutat = "";
            string ciutatNou = "";
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Contains(lletra))
                {
                    ciutat = arr[i];
                    for (int j = 0; j < ciutat.Length; j++)
                    {
                        if (ciutat[j] == lletra)
                            ciutatNou += "4";
                        else
                            ciutatNou += ciutat[j];
                    }
                    ArrayCiutatsModificades[i] = ciutatNou;
                }
                else
                    ArrayCiutatsModificades[i] = arr[i];
                ciutat = "";
                ciutatNou = "";
            }

            return ArrayCiutatsModificades;
        }
    }


}
