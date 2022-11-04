using System;
using System.Collections.Generic;

namespace _7_Delegates
{
    public class KG7
    {
        public string JoinThree(string k, string i, string j, Func<string, string, string> join)
        {
            return join(join(k, i), j);
        }
        public string JoinAllStrings(List<string> k,Func<string,string,string> join)
        {
            string j = k[0];
            for (int i = 1; i < k.Count; i++)
            {
                j = join(j, k[i]);
            }
            return j;
        }
        public T JoinAllGeneric<T>(List<T> k, Func<T, T, T> join)
        {
            T j = k[0];
            for (int i = 1; i < k.Count; i++)
            {
                j = join(j, k[i]);
            }
            return j;
        }
        public bool Exists<T>(Predicate<T> f, T[] k) 
        {
            foreach(T t in k)
            {
                if (f(t)) return true;
            }
            return false;
        }
        public T Twice<T>(Func<T, T> f,T j)
        {
            return f(f(j));
        }
    }
}
