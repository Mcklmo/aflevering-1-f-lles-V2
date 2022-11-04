using System;

namespace _5_Exceptions
{
    public class GearBox
    {
        public int gear = 1;
        public void changeGear(int newGear)
        { 
            if (newGear < -1 || newGear > 5)
            { throw new ArgumentException(); }
            if (newGear == -1 && gear != 1 || gear == -1 && newGear != 1)
            { throw new IllegalGearChangeException(); }
            if(Math.Abs(Math.Abs(gear) - Math.Abs(newGear)) > 1)
            { throw new IllegalGearChangeException(); }
            gear = newGear;
        }
    }
}
