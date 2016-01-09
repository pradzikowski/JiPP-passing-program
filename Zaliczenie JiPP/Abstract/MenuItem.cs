using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaliczenie_JiPP.Containers.Abstract
{
    abstract class MenuItem
    {
        String description;
        ConsoleKey key;
        Boolean needCtrl  = false;
        Boolean needAlt   = false;
        Boolean needShift = false;

        public MenuItem(ConsoleKey key, String description)
        {
            this.key = key;
            this.description = description;
        }

        public MenuItem(ConsoleKey key, String description, bool needCtrl, bool needAlt = false, bool needShift = false) : this(key, description)
        {
            this.needCtrl  = needCtrl;
            this.needShift = needShift;
            this.needAlt   = needAlt;
        }

        public override string ToString()
        {
            return key.ToString() + " : " + description;
        }

        public abstract void checkKey(Screen screen ,ConsoleKey key, bool needCtrl, bool needAlt, bool needShift);
    }
}
