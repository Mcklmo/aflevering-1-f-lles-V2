using System;

namespace _6_Generics
{
    class Example<U, V> where U : class
                        where V : new() //har defualt constructor
    {
        public V CreateV()
        {
            return new V();
        }
        public static T GetMax<T>(T v1, T v2) where T : IComparable
        {
            return v1.CompareTo(v2) > 1 ? v1 : v2;
        }
    }
}
