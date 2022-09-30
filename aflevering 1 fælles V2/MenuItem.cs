using System;

namespace aflevering_1_fælles_V2
{
    public class MenuItem : MainMenu, IMenuItem

    {
        public MenuItem(string _title,string _content):
            base(_title)
        { 
            Content = _content; 
        }
        string Content;
        public bool ExpandMenuItem()
        {
            Console.Clear();
            Console.WriteLine(_Title);
            Console.WriteLine(Content);
            do
            {
                ConsoleKeyInfo _key = Console.ReadKey();
                ConsoleKey key = _key.Key;
                switch (key)
                {
                    case ConsoleKey.Escape:
                        return false;
                    case ConsoleKey.Backspace:
                        return true;
                }
            } while (true);
        }
    }
}
