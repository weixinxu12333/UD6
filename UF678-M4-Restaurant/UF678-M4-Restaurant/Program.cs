using System;
using System.Collections.Generic;

namespace UF678_M4_Restaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double preuTotal = 0;

            // Amb StringComparer.CurrentCultureIgnoreCase no es sensible a majuscules i minuscules
            var menu = new Dictionary<string, double>(StringComparer.CurrentCultureIgnoreCase);
#if TRUE
            LlegirMenu(menu);
#else
            menu.Add("Hamburguesa", 2);
            menu.Add("Amanida", 5.6);
            menu.Add("Cocacola", 3);
            menu.Add("Menu 1", 30.50);
            menu.Add("Menu 2", 50);
            menu.Add("Menu 3", 20);
#endif
            ImprimirMenu(menu);
            List<string> comanda = new List<string>();
            PrendreComanda(menu, comanda);
            preuTotal = CalcularTotal(menu, comanda);
            Cobrar(preuTotal);
        }

        private static void RestaBitllets(int valor, ref double total, ref int bitllet)
        {
            while(total >= valor)
            {
                bitllet++;
                total -= valor;
            }
        }

        private static void LlegirMenu(IDictionary<string, double> menu)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Introdueix el nom del plat {i + 1}:");
                var nomPlat = Console.ReadLine();
                Console.WriteLine($"Introdueix el preu de {nomPlat}:");
                try
                {
                    var esDouble = double.TryParse(Console.ReadLine(), out var preuPlat);
                    if (!esDouble) throw new NotDoubleException();
                    menu.Add(nomPlat, preuPlat);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        private static void ImprimirMenu(IDictionary<string, double> menu)
        {
            foreach (var (nomPlat, preuPlat) in menu)
            {
                Console.WriteLine(String.Format("|{0,20}|{1,5}|", nomPlat, preuPlat));
            }
        }

        private static void PrendreComanda(IDictionary<string, double> menu, IList<string> comanda)
        {
            bool seguir = true;
            while (seguir)
            {
                Console.WriteLine("Que vols menjar?");
                string com = Console.ReadLine();

                try
                {
                    if (menu.ContainsKey(com))
                        comanda.Add(com);
                    else
                        throw new NonExistantMealException(com);

                    Console.WriteLine("Alguna cosa mes? Posa 1 (SI) o 0 (NO)");
                    bool esNumero = int.TryParse(Console.ReadLine(), out int resposta);
                    if (!esNumero || resposta < 0 || resposta > 1)
                        throw new Not0Or1Exception();
                    seguir = resposta == 1;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        private static double CalcularTotal(IDictionary<string, double> menu, IList<string> comanda)
        {
            double preuTotal = 0;
            foreach (var plat in comanda)
            {
                preuTotal += menu[plat];
            }
            return preuTotal;
        }

        private static void Cobrar(double preuTotal)
        {
            int b5 = 0, b10 = 0, b20 = 0, b50 = 0, b100 = 0, b200 = 0, b500 = 0;

            Console.WriteLine("Total a cobrar:" + preuTotal);

            RestaBitllets(500, ref preuTotal, ref b500);
            RestaBitllets(200, ref preuTotal, ref b200);
            RestaBitllets(100, ref preuTotal, ref b100);
            RestaBitllets(50, ref preuTotal, ref b50);
            RestaBitllets(20, ref preuTotal, ref b20);
            RestaBitllets(10, ref preuTotal, ref b10);
            RestaBitllets(5, ref preuTotal, ref b5);

            Console.WriteLine("Bitllets Necessaris:");
            Console.WriteLine(String.Format("|{0,7}|{1,5}|", "500", b500));
            Console.WriteLine(String.Format("|{0,7}|{1,5}|", "200", b200));
            Console.WriteLine(String.Format("|{0,7}|{1,5}|", "100", b100));
            Console.WriteLine(String.Format("|{0,7}|{1,5}|", "50", b50));
            Console.WriteLine(String.Format("|{0,7}|{1,5}|", "20", b20));
            Console.WriteLine(String.Format("|{0,7}|{1,5}|", "10", b10));
            Console.WriteLine(String.Format("|{0,7}|{1,5}|", "5", b5));
        }
    }

}
