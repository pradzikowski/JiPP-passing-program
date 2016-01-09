using System;
using Zaliczenie_JiPP.Interfaces;

namespace Zaliczenie_JiPP.Abstract
{
    public abstract class AbstractMenuHandler : HandlerInterface
    {
        protected string[] menuElements;

		protected Container container;

		public AbstractMenuHandler(){}

		public AbstractMenuHandler(Container container){
			this.container = container;
		}

        public string[] getMenuElemensts()
        {
            return menuElements;
        }

		public void setContainer(Container container) 
		{
			this.container = container;
		}

        abstract public void handle(ConsoleKeyInfo keyInfo);
    }
}
