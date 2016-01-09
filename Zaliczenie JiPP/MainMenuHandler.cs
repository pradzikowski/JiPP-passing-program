using System;
using Zaliczenie_JiPP.Abstract;

namespace Zaliczenie_JiPP
{
    class MainMenuHandler : AbstractMenuHandler
    {
		public MainMenuHandler() : base() {
			this.menuElements = new string[]
			{
				"Enter - wejście do katalogu",
				"Ctrl + Enter - wejście do katalogu wyżej",
				"key UP/DWN Przesuniecie kursora góra/dół"
			};
		}

		public MainMenuHandler(Container container) : base(container)
        {
            this.menuElements = new string[]
            {
                "Enter - wejście do katalogu",
                "Ctrl + Enter - wejście do katalogu wyżej",
                "key UP/DWN Przesuniecie kursora góra/dół"
            };
        }

        public override void handle(ConsoleKeyInfo keyInfo)
        {
			Screen screen = (Screen)this.container.get ("screen_component");

            bool altPressed = false;
            if ((keyInfo.Modifiers & ConsoleModifiers.Alt) != 0) altPressed = true;
            bool ctrlPressed = false;
            if ((keyInfo.Modifiers & ConsoleModifiers.Control) != 0) ctrlPressed = true;
            bool shiftPressed = false;
            if ((keyInfo.Modifiers & ConsoleModifiers.Shift) != 0) shiftPressed = true;

			if (keyInfo.Key == ConsoleKey.Tab)
			{
				screen.actionSwap ();
			}

            if (keyInfo.Key == ConsoleKey.DownArrow)
            {
				screen.actionDown ();
            }

			if (keyInfo.Key == ConsoleKey.UpArrow)
			{
				screen.actionUp ();
			}

			if (keyInfo.Key == ConsoleKey.Enter) {

				if (ctrlPressed) {
					screen.openParentDirectory ();
					return;
				}

				screen.openDirectory ();
			}
        }
    }
}
