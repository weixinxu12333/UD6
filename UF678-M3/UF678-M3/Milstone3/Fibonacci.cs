using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace UF678_M3
{
    public class Fibonacci : IEnumerable<ulong>
    {
        private int length;

        public Fibonacci(int length)
        {
            this.length = length;
        }

        public IEnumerator<ulong> GetEnumerator()
        {
            ulong num1 = 0;
            ulong num2 = 1;
            if (length >= 1)
            {
                yield return num1;
                if (length >= 2)
                {
                    yield return num2;
                    int iterations = 3;
                    while (length >= iterations)
                    {
                        ulong val = num1 + num2;
                        yield return val;
                        num1 = num2;
                        num2 = val;
                        iterations++;
                    }
                }
            }
        }

        // DEVUELVE OBJECTS EN VEZ DE ULONG
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
