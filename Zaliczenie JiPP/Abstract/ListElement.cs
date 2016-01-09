using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaliczenie_JiPP.Abstract
{
    abstract class ListElement : ScreenElement
    {
		protected string directory;
		protected int lines;
		protected int current;
		protected string[] list;

        abstract public override void draw();

        public ListElement(int width, int height) : base(width, height)
        {
        }

        protected void writeLine(String str)
        {
			int width = this.width;
			if((width - str.Length) > 0)
				str += "".PadLeft(width - str.Length);
			else 
            	str = str.Substring(0, width);
           
			int length = str.Length;
			Console.Write(str);
        }
    }
}
