using System.Collections.Generic;
using System;

namespace Risk
{
    public class RiskGame 
    {
        Random rnd = new Random();
        List<Dice> dices = new List<Dice>();
        public bool AllDiceNoticed(Player p)
        {
            return true;
        }
        public void Attack(Player p1,Player p2)
        {
            bool playersGotTroops = p1.TroopCount > 0 && p2.TroopCount > 0;
            dices = PrepareDice();
            p1.GetDice(dices);
            p2.GetDice(dices);
            Console.Write("Player 1 Dice: ");
            p1.WriteDice();
            Console.Write("Player 2 Dice: ");
            p2.WriteDice();
            while (p1.Dices.Count > 0 && playersGotTroops)
            {
                int p1Troops = p1.TroopCount;
                int p2Troops = p2.TroopCount;
                while(p1.GotDiceLeft() && p2.GotDiceLeft() && playersGotTroops)
                {
                    if (p1.MaxEyes().Eyes - p2.MaxEyes().Eyes > 0)
                        p2.TroopCount--;
                    else
                        p1.TroopCount--;
                    p1.MaxEyes().Noticed = true;
                    p2.MaxEyes().Noticed = true;
                    playersGotTroops = p1.TroopCount > 0 && p2.TroopCount > 0;
                }
                Console.WriteLine($"Player 1 lost {p1.TroopCount - p1Troops} Troops, has now {p1.TroopCount}.");
                Console.WriteLine($"Player 2 lost {p2.TroopCount - p2Troops} Troops, has now {p2.TroopCount}.");
                dices = PrepareDice();
                p1.GetDice(dices);
                p2.GetDice(dices);
            }
        }
        private List<Dice> PrepareDice()
        {
            List<Dice> dices = new List<Dice>();
            for(int i = 0; i< 5; i++)
            {
                dices.Add(new Dice(rnd.Next(6) + 1));
            }
            return dices;
        }
    }
}
