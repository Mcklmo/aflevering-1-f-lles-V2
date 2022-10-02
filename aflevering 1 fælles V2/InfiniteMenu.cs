namespace aflevering_1_fælles_V2
{
    internal class InfiniteMenu : MainMenu, IMenuItem
    {

        public InfiniteMenu(string _title) :
            base(_title) { }
        public new bool ExpandMenuItem()
        {
            Items.Clear(); // prevent adding additional 6 menues everytime a menu is opened
            Add(new InfiniteMenu("infinitemenu 2"));
            Add(new InfiniteMenu("infinitemenu 3"));
            Add(new InfiniteMenu("infinitemenu 4"));
            Add(new InfiniteMenu("infinitemenu 5"));
            Add(new InfiniteMenu("infinitemenu 6"));
            Add(new InfiniteMenu("infinitemenu 7"));
            return Expand();
        }
    }
}
