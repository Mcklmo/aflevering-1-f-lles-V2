using System;

namespace OOP_Kursus
{
    public class NotBreakedException : Exception
    {
        public NotBreakedException() : base() { }
        public NotBreakedException(string s) : base(s) { }
        public NotBreakedException(string s, Exception ex) : base(s, ex) { }

    }
}