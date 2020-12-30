using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UF678_M2
{
    class Milstone1
    {
        public void Inicio()
        {
            Console.WriteLine("----------FASE 1----------");
            string nom = "weixin";
            char[] arrN = nom.ToCharArray();
            Imprimir(arrN);

            Console.WriteLine("----------FASE 2----------");
            List<char> arrNom = arrN.OfType<char>().ToList();
            ComprovacioVocal(arrNom);

            Console.WriteLine("----------FASE 3----------");
            var map = new Dictionary<char, int>();
            ComprovacioKey(map, arrNom);
            ImprimirMap(map);

            Console.WriteLine("----------FASE 4----------");
            string cognom = "xu";
            char[] arrC = cognom.ToCharArray();
            List<char> arrCognom = arrC.OfType<char>().ToList();
            char[] arrComplet = arrNom.Concat(" ").Concat(arrCognom).ToArray();
            Imprimir(arrComplet);

        }

        public static void Imprimir(char [] arr)
        {
            foreach (var i in arr)
                Console.WriteLine(i);
        }

        public static void ImprimirMap(IDictionary<char, int> map)
        {
            foreach (var i in map)
                Console.WriteLine(i);
        }

        public static void ComprovacioVocal(IList<char> arr)
        {
            foreach (var i in arr)
            {
                if (i == 'a' || i == 'e' || i == 'i' || i == 'o' || i == 'u')
                    Console.WriteLine(i + " es vocal");
                else if (Char.IsDigit(i))
                    Console.WriteLine(i + ", els noms de persones no contenen números! ");
                else
                    Console.WriteLine(i + " es consonant");
            }
        }

        public static Dictionary<char, int> ComprovacioKey(IDictionary<char, int> map, IList<char> arr)
        {
            foreach (var i in arr)
            {
                if (!map.ContainsKey(i))
                    map.Add(i, 1);
                else if (map.ContainsKey(i))
                    map[i] = map[i] + 1;
            }
            return (Dictionary<char, int>) map;
        }

    }
}
