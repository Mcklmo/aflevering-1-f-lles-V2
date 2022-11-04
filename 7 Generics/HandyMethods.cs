using System;
using System.Collections.Generic;

namespace _6_Generics
{
    public class HandyMethods<T> where T : IComparable
    {
        public static T Max(List<T> t)
        {
            T max = t[0];
            foreach (T item in t)
            {
                if (max.CompareTo(item) < 0)
                    max = item;
            }
            return max;
        }
        public static T Min(List<T> t)
        {
            T max = t[0];
            foreach (T item in t)
            {
                if (max.CompareTo(item) > 0)
                    max = item;
            }
            return max;
        }
        public static void Copy(T[] v1, T[] v2)
        {
            if (v1.Length != v2.Length)
            {
                throw new ArgumentException();
            }
            v1.CopyTo(v2, 0);
        }
        public static void Shuffle(T[] ar)
        {
            Random random = new Random();
            for(int i = 0; i < ar.Length; i++)
            {
                int j = random.Next(ar.Length);
                int k = random.Next(ar.Length);
                T element = ar[j];
                ar[j] = ar[k];
                ar[k] = element;
            }
        }
    }
}
