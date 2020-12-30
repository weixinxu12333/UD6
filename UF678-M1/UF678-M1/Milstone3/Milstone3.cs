using System;
using System.Collections.Generic;
using System.Text;

namespace UF678_M1
{
    class Milstone3
    {
        public void inicio()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            RevertirArray(arr);
            Imprimir(arr);
        }
        public static int[] RevertirArray(int[] arr)
        {
            int aux;
            for (int i = 0; i < arr.Length / 2; i++)
            {
                aux = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = aux;
            }
            return arr;
        }

        public static void Imprimir(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
