﻿using System;
using System.Collections.Generic;

namespace aflevering_1_fælles_V2
{
    public class Menu : MainMenu, IMenuItem
    {
        public Menu(string _title) :
            base(_title)
        { }
        public bool ExpandMenuItem()
        {
            running = true;
            bool LeaveMenu;
            do
            {
                DrawMenu();
                LeaveMenu = HandleInput();
            }
            while (running);

            return LeaveMenu;
        }
    }
}
