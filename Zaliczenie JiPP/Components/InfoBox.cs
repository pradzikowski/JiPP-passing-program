using System;
using Zaliczenie_JiPP.Abstract;

namespace Zaliczenie_JiPP
{
    internal class InfoBox : ScreenElement
    {
        private AbstractMenuHandler handler;

        public InfoBox(Container container) : this(container.getConfig(), container.getCurrentHandler())
        {}

        public InfoBox(Config config, AbstractMenuHandler handler) : base(config.Width, calculateHeight(config, handler.getMenuElemensts()))
        {
            this.handler = handler;
        }

        public override void draw()
        {
			int i = 0;
			String[] elements = handler.getMenuElemensts ();
			foreach( var element in elements)
			{
				Console.Write (element);
				i++;

				if (i < elements.Length)
					Console.WriteLine ();
			}
        }

        static int calculateHeight(Config conf, String[] menuElements)
        {
			return menuElements.Length;
        }
    }
}