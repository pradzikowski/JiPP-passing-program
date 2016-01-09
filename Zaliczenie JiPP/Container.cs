using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Zaliczenie_JiPP.Abstract;
using Zaliczenie_JiPP.Interfaces;

namespace Zaliczenie_JiPP
{
    public class Container
    {
        private Dictionary<string, object> entries;

        public Container()
        {
            entries = new Dictionary<string, object>();
        }

        public Container(Dictionary<string, object> entires)
        {
            this.entries = entires;
        }

        public object get(string name)
        {
            return entries[name];
        }

        public void set(string name, object entry)
        {
            entries[name] = entry;
        }

        public AbstractMenuHandler getCurrentHandler()
        {
            return (AbstractMenuHandler)this.get("current_handler");
        }

        public void setCurrentHandler(AbstractMenuHandler handler)
        {
            entries["current_handler"] = handler;
        }

        public void setCurrentHandler(string handlerName)
        {
            entries["current_handler"] = this.get(handlerName);
        }

        public Config getConfig()
        {
            return (Config) this.get("config");
        }

        public void setConfig(Config conf)
        {
            this.set("config", conf);
        }
    }
}