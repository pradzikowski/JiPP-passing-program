using System;
using System.IO;
using System.Linq;
using Zaliczenie_JiPP.Abstract;

namespace Zaliczenie_JiPP.Components
{
    class FileList : ListElement
    {
        public FileList(int height, int width) : base(width, height) 
		{
			this.directory = Environment.GetFolderPath (Environment.SpecialFolder.UserProfile);
		}

		public FileList(string directory, int height, int width) : base(width, height)
        {
            this.directory = directory;
        }

        public void draw(int line)
        {
            if (line < lines)
            {
                if (line == current)
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                }
				String str = Path.GetFileName(list[line]);
				writeLine (str);
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                return;
            }
            Console.Write("".PadLeft(width));
        }

        public void refreshDirectory()
        {
			list = Directory.GetFileSystemEntries (directory);
            lines = list.Count();
            this.current = 0;
        }

        public override void draw()
        {
            for(int i =0; i<height; i++)
            {
                draw(i);
            }
        }

		public string getCurrentName() {
			return Path.GetFileName (list [current]);
		}

		public void actionDown ()
		{
			if (current == (list.Length - 1))
				return;

			current++;
		}

		public void actionUp ()
		{
			if (current == 0)
				return;

			current--;
		}

		public void openDirectory ()
		{
			if(Directory.Exists(list[current])) {
				directory = list[current];
				refreshDirectory ();
			}
		}

		public void openParentDirectory ()
		{
			this.directory = Directory.GetParent (directory).FullName;
			refreshDirectory ();
		}

		public void printCurrentName(int parentWidth) {
			int thisWidth = this.width;
			this.width = parentWidth-1;
			this.writeLine ("Current: " + this.getCurrentName ());
			this.width = thisWidth;
		}
    }
}
