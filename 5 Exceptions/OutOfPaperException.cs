using System;

namespace _5_Exceptions
{
    public class OutOfPaperException : Exception
    {
        public OutOfPaperException() : base() { }
        public OutOfPaperException(string s) : base(s) { }
        public OutOfPaperException(string s, Exception ex) : base(s, ex) { }
    }
}
