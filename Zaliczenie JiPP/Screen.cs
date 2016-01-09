using System;
using Zaliczenie_JiPP.Abstract;
using Zaliczenie_JiPP.Components;

namespace Zaliczenie_JiPP
{
    class Screen : ScreenElement
    {
		string message = "";

        private int screenType;

		FileList[] fileLists;
        InfoBox infoBox;
		bool chooseList = false;
		Container container;

        public Screen(Config config, AbstractMenuHandler handler) : base(config)
        {
            screenType = config.ScreenType;

            infoBox   = new InfoBox(config, handler);
			fileLists = new FileList[] {
				new FileList(height-infoBox.Height-2, width/2-4),
				new FileList(height-infoBox.Height-2, width/2-4)
			};

			fileLists [0].refreshDirectory ();
			fileLists [1].refreshDirectory ();
        }

        public Screen(Container container):this(container.getConfig(), container.getCurrentHandler())
        {
			this.container = container;
		}

		public void setContainer(Container container) 
		{
			this.container = container;
		}

        public override void draw()
        {
			int listHeight = height - infoBox.Height-3;
			for(int i =0; i < listHeight; i++)
            {
				fileLists[0].draw(i);
				string separator = (!chooseList)? "<|| " : " ||>";
                Console.Write(separator);
				fileLists[1].draw(i);
                Console.WriteLine("");
            }
			printHorizontalSeparator();
			printCurrentFileName ();
			printHorizontalSeparator();
            infoBox.draw();
			printMessage ();
        }

		void printHorizontalSeparator() {
			Console.WriteLine("".PadRight(width-1, '-'));
		}

		void printCurrentFileName() {
			container.getConfig().setConsolHighlightColor ();
			getCurrentList().printCurrentName (width);
			container.getConfig().setConsolDefaultColor ();
		}

		FileList getCurrentList(){
			return fileLists [(chooseList) ? 1 : 0];
		}

		public void actionSwap() {
			chooseList = !chooseList;
		}

		public void actionDown ()
		{
			getCurrentList().actionDown ();
		}

		public void actionUp ()
		{
			getCurrentList().actionUp ();
		}

		public void openDirectory ()
		{
			try{
				
				getCurrentList ().openDirectory ();
			} catch (Exception e) {
				
				message = e.Message;
				if (message.Length > width) {
					message = message.Substring (0, width);
				}
			}
		}

		public void openParentDirectory ()
		{
			try{

				getCurrentList ().openParentDirectory ();
			} catch (Exception e) {

				message = e.Message;
				if (message.Length > width) {
					message = message.Substring (0, width);
				}
			}
		}

		void printMessage ()
		{
			if (message.Length == 0)
				return;

			container.getConfig ().setConsolHighlightColor();
			Console.SetCursorPosition (0, 0);
			Console.Write (message);
			message = "";
			container.getConfig ().setConsolDefaultColor ();
		}
    }
}
