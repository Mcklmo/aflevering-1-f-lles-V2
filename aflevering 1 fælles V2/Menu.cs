using System;
using System.Collections.Generic;

namespace aflevering_1_fælles_V2
{
    public class Menu : MainMenu, IMenuItem
    {
        bool running=true;
        public Menu(string _title) :
            base(_title)
        { }

        List<IMenuItem> Items = new List<IMenuItem>();
        int selected=0;
        public void Add(IMenuItem item)
        {
            Items.Add(item);
        }
        public void Start()
        {
            ExpandMenuItem();
        }
        private bool HandleInput()
            {
            ConsoleKeyInfo cki = Console.ReadKey();
            switch (cki.Key)
            {
                case ConsoleKey.Backspace :
                    running = false;
                    return true;
                case ConsoleKey.Escape:
                    running = false;
                    return false;
                    //throw new Exception("done");
                case ConsoleKey.UpArrow:
                    selected = selected == 0 ? Items.Count - 1 : selected - 1;
                    break;
                case ConsoleKey.DownArrow:
                    selected = (selected + 1) % Items.Count;
                    break;
                case ConsoleKey.Enter :
                    running = Items[selected].ExpandMenuItem();
                    return running;
            }
            return true;
        }
        public bool ExpandMenuItem()
        {
            bool LeaveMenu;
            do
            {
                DrawMenu();
                LeaveMenu = HandleInput();
            }
            while (running);

            return LeaveMenu;
        }
        public bool DrawMenu()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(_Title);
            Console.ResetColor();
            foreach(IMenuItem item in Items)
            {
                if (item == Items[selected])
                {
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine(item.Title());
                    Console.ResetColor();
                    continue;
                }
                Console.WriteLine(item.Title());
            }
            return true;
        }
    }
}
