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
            try
            {
                menu.Start();
            }
            catch (Exception e)
            { // smart way to stop the program when the user hits enter
                if (e.Message == "done") { }
                else throw e; 
            }
        }
    }
}
