using System;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aflevering_1_fælles_V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            moritz();
            //malthe();
        }
        //private static void malthe()
        //{
        //    IMenu baseMenu = new CustomMenu("Menu", "Dette er den første menu");

        //    baseMenu.Add(new CustomMenu("Menu 1", "Dette er den første menu"));

        //    IMenu menu2 = new CustomMenu("Menu 2", "Dette er den anden menu");

        //    menu2.Add(new CustomMenu("Menu 2-1", "Dette er den anden-første menu"));
        //    menu2.Add(new CustomMenu("Menu 2-2", "Dette er den anden-anden  menu"));

        //    baseMenu.Add(menu2);
        //    baseMenu.Add(new FileSystemMenu("File system", "C:\\Users\\malth\\Desktop"));


        //    baseMenu.Show();
        //}

        private static void moritz()
        {
            Menu menu = new Menu(" fancymenu ");
            menu.Add(
                new MenuItem(
                    " Punkt1 ",
                    " Indhold af punkt 1... det er indtil videre bare tekst "
            ));
            menu.Add(
                new MenuItem(
                    " Punkt2 ",
                    " Indhold af punkt 2... det er indtil videre også bare tekst "
            ));
            menu.Add(
                new MenuItem(
                    "Et lidt længere menupunkt ",
                    " Indhold af punkt 3... det er indtil videre også bare tekst "
            ));

            Menu menu2 = new Menu(" fancymenu 2 ");
            menu2.Add(
                new MenuItem(
                    " Punkt1.2 ",
                    " Indhold af punkt 1... det er indtil videre bare tekst "
            ));
            menu2.Add(
                new MenuItem(
                    " Punkt2.2 ",
                    " Indhold af punkt 2... det er indtil videre også bare tekst "
            ));
            menu2.Add(
                new MenuItem(
                    "Et lidt længere menupunkt.2 ",
                    " Indhold af punkt 3... det er indtil videre også bare tekst "
            ));
            menu.Add(menu2);
            menu.Start();
        }
    }
}
