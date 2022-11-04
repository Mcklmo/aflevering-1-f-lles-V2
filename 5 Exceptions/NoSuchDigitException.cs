using System;

namespace _5_Exceptions
{
    public class NoSuchDigitException : Exception
    {
        public NoSuchDigitException() : base() { }
        public NoSuchDigitException(string s) : base(s) { }
        public NoSuchDigitException(string s, Exception ex) : base(s, ex) { }

    }
}