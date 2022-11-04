using System;

namespace OOP_Kursus
{
    public class ClutchNotPressedException : Exception
    {
        public ClutchNotPressedException() : base() { }
        public ClutchNotPressedException(string s) : base(s) { }
        public ClutchNotPressedException(string s, Exception ex) : base(s, ex) { }
    }
}