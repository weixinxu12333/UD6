using System;
using System.Collections.Generic;
using System.Text;

namespace UF678_M3
{
    class Milstone2
    {
        public void Inici()
        {
            double[,] notes = new double[5,3];

            for (int i = 0; i < notes.GetLength(0); i++)
            {
                Console.WriteLine("Introduir notes de l'alumne :" + i);
                for (int j = 0; j < notes.GetLength(1); j++)
                {
                    Console.WriteLine("Introduir nota {0} de l'alumne {1}", j, i);
                    notes[i,j] = Convert.ToDouble(Console.ReadLine());
                }
            }

            for (int i = 0; i < notes.GetLength(0); i++)
            {
                double suma = 0;
                for (int j = 0; j < notes.GetLength(1); j++)
                {
                    suma += notes[i, j];
                }
                double mitjana = suma / notes.GetLength(1);
                Console.WriteLine("Mitja de l'alumne {0}: {1} L'alumne ha {2}", i, mitjana, mitjana >= 5 ? "aprovat" : "suspes" );
            }

        }
    }
}
