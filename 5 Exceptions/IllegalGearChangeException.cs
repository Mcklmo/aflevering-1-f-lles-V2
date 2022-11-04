using System;

namespace _5_Exceptions
{
    public class IllegalGearChangeException : Exception
    {
        public IllegalGearChangeException() : base() { }
        public IllegalGearChangeException(string s) : base(s) { }
        public IllegalGearChangeException(string s, Exception ex) : base(s, ex) { }
    }
}
