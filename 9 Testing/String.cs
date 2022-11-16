namespace _9_Testing
{
    public class String 
    {
        public char[] Chars;
        public String(char[] chars)
        {
            Chars = chars;
        }
        public char CharAt(int i)
        {
            return Chars[i];
        }
        public int Length()
        {
            return Chars.Length;
        }
        public char[] Substring(int i,int j)
        {
            char[] result = new char[Chars.Length];
            while (i < j)
            {
                result[i] = Chars[i];
                i++;
            }
            return result;
        }
        public char[] ToLowerCase()
        {
            char[] result = new char[Chars.Length];
            for(int i = 0; i < Chars.Length; i++) 
            {
                result[i] = char.ToLower(Chars[i]);
            }
            return result;
        }
        public bool Equals(char[] s)
        {
            if (s.Length != Chars.Length) 
                return false;
            for(int i = 0; i < Chars.Length; i++)
            {
                if (Chars[i] != s[i])
                    return false;
            }
            return true;
        }
    }
}
