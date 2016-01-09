using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaliczenie_JiPP
{
    class MenuHandler
    {
        Dictionary<String, String> menu;

        public Dictionary<string, string> Menu
        {
            get
            {
                return menu;
            }
        }

        public MenuHandler()
        {
            menu = new Dictionary<string, string>
            {
                { "Ctrl + X", "Wyjście z programu" },
                { "tab", "Zmiana okna" },
                { "key UP/DWN", "Przesuniecie kursora góra/dół" },
                { "m", "przeniesienie pliku na przeciwną stronę" }
            };
        }
    }
}
