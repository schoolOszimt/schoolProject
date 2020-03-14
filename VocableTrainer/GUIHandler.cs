using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VocableTrainer
{
    class GUIHandler
    {
        private GUIGame gameGui = GUIGame.GetInstance();
        private GUIMenu menuGui = GUIMenu.GetInstance();
        private static GUIHandler instance;
        private GUIHandler()
        {
            gameGui.SetVisibility(false);
            menuGui.SetVisibility(true);
        }
        public static GUIHandler GetInstance()
        {
            if (instance == null) instance = new GUIHandler();
            return instance;
        }
        public void ToMenu()
        {
            gameGui.SetVisibility(false);
            menuGui.SetVisibility(true);
        }

        public void Start()
        {
            gameGui.SetVisibility(true);
            menuGui.SetVisibility(false);
        }
    }
}
