using System;
using System.Collections.Generic;

namespace Risk
{

    public class Attacker : Player
    {
        public Attacker(int _TroopCount) : base(_TroopCount)
        {
        }
        public override int MaxDiceNum => 3;
        public override int MaxDiceByTroops => TroopCount -1 ;
    }
    public class Defender : Player
    {
        public Defender(int _TroopCount) : base(_TroopCount)
        {
        }
        public override int MaxDiceNum => 2;
        public override int MaxDiceByTroops => TroopCount;
    }
    public abstract class Player
    {
        public Player(int nOfTroops) 
        {
            TroopCount = nOfTroops;
            //GetDice();
        }
        public abstract int MaxDiceNum
        {
            get;
        }
        public abstract int MaxDiceByTroops
        {
            get;
        }
        public int TroopCount;
        public List<Dice> Dices = new List<Dice> ();
        public void GetDice(List<Dice> dices)
        {
            // takes correct number of dices from list with many dices
            while ( Dices.Count < MaxDiceByTroops && Dices.Count < MaxDiceNum)
            {
                Dice dice = dices[0];
                Dices.Add(dice);
                dices.Remove(dice);
            }
        }
        public void WriteDice()
        {
            foreach(Dice dice in Dices)
            {
                Console.Write(dice.Eyes + " ");
            }
            Console.WriteLine();
        }
        public bool GotDiceLeft()
        {
            foreach(Dice dice in Dices)
                if (dice.Noticed == false)
                    return true;
            return false;
        }
        public Dice MaxEyes()
        {
            Dice max = Dices[0];
            foreach(Dice dice in Dices)
            {
                if(max.CompareTo(dice) < 0)
                {
                    max = dice;
                }
            }
            return max;
        }
    }
}
