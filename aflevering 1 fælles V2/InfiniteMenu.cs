namespace aflevering_1_fælles_V2
{
    internal class InfiniteMenu : MainMenu, IMenuItem
    {

        public InfiniteMenu(string _title):
            base(_title) { }
        public bool ExpandMenuItem()
        {
            // add 6 infinite submenues to this on the run
            Add(new InfiniteMenu("infinitemenu 2"));
            Add(new InfiniteMenu("infinitemenu 3"));
            Add(new InfiniteMenu("infinitemenu 4"));
            Add(new InfiniteMenu("infinitemenu 5"));
            Add(new InfiniteMenu("infinitemenu 6"));
            Add(new InfiniteMenu("infinitemenu 7"));

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
