using System;
using System.CodeDom;
using System.Collections.Generic;
using Zaliczenie_JiPP.Abstract;

namespace Zaliczenie_JiPP
{
    class Program
    {
		static bool isEnd = false;

        static void Main(string[] args)
        {
            Container container = createContainer();

			configureConsole (container.getConfig());
            Screen screen = new Screen(container);
			container.set("screen_component", screen);

			do {
                Console.Clear();
				Console.SetCursorPosition(0,0);
                screen.draw();
                container
                    .getCurrentHandler()
                    .handle(Console.ReadKey(false));
			} while(false == isEnd);
        }

		static void configureConsole(Config conf) {
			Console.Clear();
			Console.SetWindowSize (conf.Width, conf.Height);
			Console.BufferHeight = conf.Height;
			Console.BufferWidth = conf.Width;
			Console.CursorVisible = false;
			conf.setConsolDefaultColor ();
		}

        static Container createContainer()
        {
            AbstractMenuHandler handler = new MainMenuHandler();

			Container container =  new Container(
                    new Dictionary<string, object>()
                    {
                        {"menu_handler", handler},
                        {"current_handler", handler},
                        {"config", new Config()}
                    }
                );

			handler.setContainer (container);
			return container;
        }
    }
}
