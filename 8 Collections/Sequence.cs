using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;

namespace _8_Collections
{
    public class Sequence : IEnumerator<int>
    {

        List<int> l = new List<int>();
        public int current;
        public int start, end, skip;

        public int Current => l[current];
        public Sequence(List<int> _l,int _start,int _end,int _skip)
        {
            l = _l;
            start = _start;
            current = start;
            end = _end;
            skip = _skip;
        }

        object IEnumerator.Current => l[current];

        public void Dispose()
        {
            // :) :)
        }
        public IEnumerator GetEnumerator()
        {
            return l.GetEnumerator();
        }

        public bool MoveNext()
        {
            if (l.Count <= start ||end <= current-1+skip)
            {
                return false;
            }
            return true;
        }

        public void Reset()
        {
            current = 0;
        }
    }
}
