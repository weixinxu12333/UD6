using System;
using System.Collections.Generic;
using System.Text;

namespace UF678_M1
{
    class Milstone1
    {
        public void inicio()
        {
            string nom = "Weixin", cognom1 = "Xu", cognom2 = "";
            int dia = 11, mes = 11, any = 1996;
            const int anyTraspas = 1948;
            AnyTraspas(anyTraspas, any);
            EsTraspas(anyTraspas, any);
            Imprimir(nom, cognom1, cognom2, dia, mes, any);
        }
        public void AnyTraspas(int anyTraspas,int any)
        {
            Console.WriteLine("--------FASE 2--------");
            int aTraspas = anyTraspas;
            while (aTraspas <= any)
            {
                Console.WriteLine("L'any {0} es un any traspas", aTraspas);
                aTraspas = aTraspas + 4;
            }
        }

        public void EsTraspas(int anyTraspas, int any)
        {
            string hoEs = "es any traspas", noHoEs = "no es any traspas";
            Console.WriteLine("--------FASE 3--------");
            for (int i = anyTraspas; i <= any; i++)
            {
                if (DateTime.IsLeapYear(i))
                    Console.WriteLine("L'any {0} {1}", i, hoEs);
                else
                    Console.WriteLine("L'any {0} {1}", i, noHoEs);
            }
        }

        public void Imprimir(string nom, string cognom1, string cognom2, int dia, int mes, int any)
        {
            Console.WriteLine("--------FASE 4--------");
            string nomComplet = nom + " " + cognom1 + " " + cognom2;
            string dataNaixement = dia + "/" + mes + "/" + any;

            Console.WriteLine("El meu nom es " + nomComplet);
            Console.WriteLine("Vaig néixer el " + dataNaixement);
            Console.WriteLine("El meu any de naixement es any traspas");
        }

    }
}
