using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VocableTrainer
{
    class GUIHandler
    {
        private GUIGame gameGui = GUIGame.getInstance();
        private GUIMenu menuGui = GUIMenu.getInstance();
        private static GUIHandler instance;
        private GUIHandler()
        {
            gameGui.setVisibility(false);
            menuGui.setVisibility(true);
        }
        public static GUIHandler getInstance()
        {
            if (instance == null) instance = new GUIHandler();
            return instance;
        }
        public void toMenu()
        {
            gameGui.setVisibility(false);
            menuGui.setVisibility(true);
        }

        public void start()
        {
            gameGui.setVisibility(true);
            menuGui.setVisibility(false);
        }
    }
}
