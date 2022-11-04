using System;

namespace _5_Exceptions
{
    public class IllegalDigitException : Exception
    {
        public IllegalDigitException() : base() { }
        public IllegalDigitException(string s) : base(s) { }
        public IllegalDigitException(string s, Exception ex) : base(s, ex) { }
    }
}