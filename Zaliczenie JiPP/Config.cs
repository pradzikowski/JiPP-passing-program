using System;
using Zaliczenie_JiPP.Interfaces;

namespace Zaliczenie_JiPP
{
	public class Config
    {
        int width;
        int height;

        String homeLeft;
        String homeRight;

        int screenType;

        enum ScreenTypes { Single = 1, Double};

        public Config()
        {
            width  = 120;
            height = 30;
            homeLeft   = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            homeRight  = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            screenType = (int)ScreenTypes.Double;

        }

        public int Width
        {
            get
            {
                return width;
            }
        }

        public int Height
        {
            get
            {
                return height;
            }
        }

        public String HomeLeft
        {
            get
            {
                return homeLeft;
            }
        }

        public String HomeRight
        {
            get
            {
                return homeRight;
            }
        }

        public int ScreenType
        {
            get
            {
                return screenType;
            }
        }

        public Config setHeight(int height)
        {
            this.height = height;

            return this;
        }

        public Config setWidth(int width)
        {
            this.width = width;

            return this;
        }

		public void setConsolDefaultColor()
		{
			Console.BackgroundColor = ConsoleColor.DarkBlue;
		}

		public void setConsolHighlightColor()
		{
			Console.BackgroundColor = ConsoleColor.DarkRed;
		}
    }
}
