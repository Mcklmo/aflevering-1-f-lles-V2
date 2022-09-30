namespace aflevering_1_fælles_V2
{
    public abstract class MainMenu {
        public MainMenu(string _title)
        {
            _Title = _title;
        }
        public string _Title;
        public string Title()
        { return _Title; }
    }
}
