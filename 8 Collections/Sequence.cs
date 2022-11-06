using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;

namespace _8_Collections
{
    public class Sequence : IEnumerable<int>
    {
        public int Start { get; }
        public int Skip { get; }
        public int Count { get; }
        private bool Unlimited { get; }
        private bool Fib = false;
        public Sequence(int start, int skip)
        {
            Start = start;
            Skip = skip;
            Unlimited = true;
        }
        public Sequence(int start, int skip, int count)
        {
            Start = start;
            Skip = skip;
            Count = count;
        }
        public Sequence(string fib, int count)
        {
            Start = 1;
            Count = count;
            if (fib == "f")
            {
                Fib = true;

            }
            else
            {
                throw new ArgumentException();
            }
        }
        public IEnumerator<int> GetEnumerator() { 
            if (Fib) 
                return new FibEnumerator(this);
            else 
                return new SequenceEnumerator(this); 
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        private class FibEnumerator : IEnumerator<int>
        {
            Sequence Sequence { get; }
            public FibEnumerator(Sequence sequence)
            {
                Sequence = sequence;
                Reset();
            }
            public int Count { get; private set; }
            public int Current { get; private set; }
            public int Previous { get; private set; }
            public int Next { get; private set; }
            object IEnumerator.Current => Current;
            public void Dispose() { }
            public bool MoveNext()
            {
                Next = Current + Previous;
                Previous = Current;
                Current = Next;
                return Count-- > 0 || Sequence.Unlimited;
            }
            public void Reset()
            {
                Count = Sequence.Count;
                Current = Sequence.Start;
                Previous = 0;
            }
        }
        private class SequenceEnumerator : IEnumerator<int>
        {
            Sequence Sequence { get; }
            public SequenceEnumerator(Sequence sequence)
            {
                Sequence = sequence;
                Reset();
            }
            public int Count { get; private set; }
            public int Current { get; private set; }
            object IEnumerator.Current => Current;
            public void Dispose() { }
            public bool MoveNext()
            {
                Current += Sequence.Skip;
                return Count-- > 0 || Sequence.Unlimited;
            }
            public void Reset()
            {
                Count = Sequence.Count;
                Current = Sequence.Start - Sequence.Skip;
            }
        }
    }
}
