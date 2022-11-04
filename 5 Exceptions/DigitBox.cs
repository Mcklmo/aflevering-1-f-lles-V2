using System;

namespace _5_Exceptions
{
    public class DigitBox
    {
        int[] digits = { 0, 0, 0, 0 };
        public int GetDigit(int i)
        {
            if (i < 0 || i > 3) { throw new NoSuchDigitException(); }
            return digits[i];
        }
        public void SetDigit(int i, int v)
        {
            if (i < 0 || i > 3) { throw new NoSuchDigitException(); }
            if (Math.Abs(v) > 9) { throw new IllegalDigitException(); }
            digits[i] = v;
        }
    }
}
