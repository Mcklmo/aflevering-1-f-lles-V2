using System;
using System.Collections.Generic;

namespace Miniprojekt_1

{
    public class Menu : MainMenu, IMenuItem
    {
        public Menu(string _title) :
            base(_title)
        { }
    }
}
