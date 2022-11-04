using System;

namespace Risk
{
    public class Dice : IComparable
    {
        public Dice(int _eyes)
        {
            Eyes = _eyes;
        }
        public int Eyes;
        public bool Noticed = false;

        public int CompareTo(object dice)
        {
            Dice dice2 = (Dice)dice;
            if (Noticed) return -1;
            return Eyes.CompareTo(dice2.Eyes);
        }
    }
}
