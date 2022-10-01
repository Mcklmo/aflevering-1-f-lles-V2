namespace aflevering_1_fælles_V2
{
    internal class InfiniteMenu : IMenuItem
    {
        private string _Title;

        public InfiniteMenu(string _title)
        {
            _Title = _title;
        }

        public void DrawMenu()
        {
            throw new System.NotImplementedException();
        }

        public bool ExpandMenuItem()
        {
            throw new System.NotImplementedException();
        }

        public string Title()
        {
            return _Title;
        }
    }
}