using System.Collections.Generic;
using System;

namespace Miniprojekt_1
{
    public abstract class MainMenu {
        public MainMenu(string _title)
        {
            _Title = _title;
        }
        public string _Title;
        public List<IMenuItem> Items = new List<IMenuItem>();
        public int selected = 0;
        public bool running = true;
        public string Title()
        { return _Title; }
        public void Add(IMenuItem item)
        {
            Items.Add(item);
        }
        public void DrawMenu()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(_Title);
            Console.ResetColor();
            foreach (IMenuItem item in Items)
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
        }
        public bool HandleInput()
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
        public bool Expand()
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
        public bool ExpandMenuItem()
        {
            return Expand();
        }
    }
}
