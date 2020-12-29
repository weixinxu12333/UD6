using System;

namespace UF678_M4_Restaurant
{
    class Not0Or1Exception : Exception
    {
        public Not0Or1Exception() : base("No ha introduit 0 o 1") { }
    }
}
