using System;

namespace _5_Exceptions
{
    public class InsufficientFundsException : Exception
    {
        public InsufficientFundsException() : base() { }
        public InsufficientFundsException(string s): base (s){}
        public InsufficientFundsException (string s, Exception ex) : base (s,ex) { }
    }
}
