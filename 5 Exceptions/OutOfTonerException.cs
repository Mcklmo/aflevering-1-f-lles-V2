using System;

namespace _5_Exceptions
{
    public class OutOfTonerException : Exception
    {
        public OutOfTonerException() : base() { }
        public OutOfTonerException(string s) : base(s) { }
        public OutOfTonerException(string s, Exception ex) : base(s, ex) { }
    }
}
