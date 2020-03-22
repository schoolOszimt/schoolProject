using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VocableTrainer
{
    class GUIHandler
    {
        private GUIGame gamegui = GUIGame.GetInstance();
        private static GUIHandler instance;

        public static GUIHandler GetInstance()
        {
            if (instance == null) instance = new GUIHandler();
            return instance;
        }
    }
}
