using System;

namespace _5_Exceptions
{
    public class PaperJamException : Exception
    {
        public PaperJamException() : base() { }
        public PaperJamException(string s) : base(s) { }
        public PaperJamException(string s, Exception ex) : base(s, ex) { }
    }
}
