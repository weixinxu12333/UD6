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
            ArrayCiutatsModificades = ModificarLletra(arrayCiutats, 'a');
            Array.Sort(ArrayCiutatsModificades);
            ImprimirArray(ArrayCiutatsModificades);

            Console.WriteLine("----------Fase 4----------");
            char[] barcelona = new char[c1.Length];
            char[] madrid = new char[c2.Length];
            char[] valencia = new char[c3.Length];
            char[] malaga = new char[c4.Length];
            char[] cadiz = new char[c5.Length];
            char[] santander = new char[c6.Length];

            barcelona = OmplirArrayPerNomCiutat(c1);
            madrid = OmplirArrayPerNomCiutat(c2);
            valencia = OmplirArrayPerNomCiutat(c3);
            malaga = OmplirArrayPerNomCiutat(c4);
            cadiz = OmplirArrayPerNomCiutat(c5);
            santander = OmplirArrayPerNomCiutat(c6);

            Array.Reverse(barcelona);
            Array.Reverse(madrid);
            Array.Reverse(valencia);
            Array.Reverse(malaga);
            Array.Reverse(cadiz);
            Array.Reverse(santander);

            ImprimirArray(barcelona);
            ImprimirArray(madrid);
            ImprimirArray(valencia);
            ImprimirArray(malaga);
            ImprimirArray(cadiz);
            ImprimirArray(santander);

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

        public static void ImprimirArray(char[] array)
        {
            foreach (var i in array)
            {
                Console.Write(i);
            }
            Console.WriteLine();
        }

        public static string[] ModificarLletra(string[] arr, char lletra)
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

        public static char[] OmplirArrayPerNomCiutat(string nom)
        {
            char[] array = new char[nom.Length];
            for (int i = 0; i < nom.Length; i++)
                array[i] = nom[i];
            return array;
        }


    }
}
