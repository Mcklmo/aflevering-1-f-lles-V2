using System;

namespace OOP_Kursus
{
    public class Car
    {
        bool clutched=false, ignited = false, breaked = true;
        public void PressClutch()
        {
            clutched = true;
        }
        public void ReleaseClutch()
        {
            clutched = false;
            Console.WriteLine("Car driving");

        }
        public void Ignition()
        {
            if(!clutched)
            {
                throw new ClutchNotPressedException();
            }
            if(!breaked)
            {
                throw new NotBreakedException();
            }
            ignited = true;
        }
        public void PullBreak()
        {
            breaked = true;
        }
        public void ReleaseBreak()
        {
            breaked = false;
        }
    }
}