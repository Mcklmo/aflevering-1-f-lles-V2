using System;

namespace aflevering_1_fælles_V2
{
    public class MenuItem :  IMenuItem

    {
        public MenuItem(string _title,string _content)
        { 
            Content = _content;
            _Title = _title;
        }
        string Content;
        public string _Title;
        public string Title()
        { return _Title; }
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
