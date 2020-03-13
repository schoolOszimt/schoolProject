using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VocableTrainer
{
    class GUIMenu
    {
        private static GUIMenu instance;
        private static GUIHandler handler = GUIHandler.getInstance();
        private GUIMenu() { }
        public static GUIMenu getInstance()
        {
            if (instance == null) instance = new GUIMenu();
            return instance;
        }
        public static void start()
        {
            // TODO: Dominik nutzt funktion auf buttonn start
            handler.start();
        }
        public void setVisibility(bool visibility)
        {
            // TODO: Dominik setzt hier menu visibility ein 
        }
        public static void close()
        {
            System.Environment.Exit(0);
        }
    }
}
