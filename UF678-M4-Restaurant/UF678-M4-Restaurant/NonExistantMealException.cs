using System;

namespace UF678_M4_Restaurant
{
    class NonExistantMealException : Exception
    {
        public NonExistantMealException(string meal) : base($"El plat {meal} no existeix") { }
    }
}
