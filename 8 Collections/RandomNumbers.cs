using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _8_Collections
{
    public class RandomNumbers : IEnumerable<int>
    {
        public RandomNumbers(int count)
        {
            Count = count;
        }
        public RandomNumbers(int count, int max)
        {
            Count = count;
            Max = max;
        }
        public RandomNumbers(int count, int max,int min)
        {
            Count = count;
            Max = max;
            Min= min;
        }
        public int Count;
        public int Max = int.MaxValue;
        public int Min = 0;
        public IEnumerator<int> GetEnumerator() => new RandomEnumerator(this);

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        private class RandomEnumerator : IEnumerator<int>
        {
            Random rand = new Random();
            RandomNumbers Rn { get; }
            public RandomEnumerator(RandomNumbers rn)
            {
                Rn = rn;
                Reset();
            }
            private int Count;
            public int Current { get; private set; }
            object IEnumerator.Current => Current;

            public bool MoveNext()
            {
                Current = rand.Next(Rn.Min, Rn.Max);
                return Count-- > 0;
            }

            public void Reset()
            {
                Count = Rn.Count;
            }

            public void Dispose()
            {
            }
        }
    }
}
