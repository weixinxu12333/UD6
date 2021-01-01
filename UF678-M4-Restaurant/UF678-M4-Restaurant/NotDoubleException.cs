using System;

namespace UF678_M4_Restaurant
{
    class NotDoubleException : Exception
    {
        public NotDoubleException() : base("No s'ha introduit un numero") { }
    }
}
