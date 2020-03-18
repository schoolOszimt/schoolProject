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
        private static GUIHandler handler = GUIHandler.GetInstance();
        private GUIMenu() { }
        public static GUIMenu GetInstance()
        {
            if (instance == null) instance = new GUIMenu();
            return instance;
        }
        public static void Start()
        {
            handler.Start();
        }
        public void SetVisibility(bool visibility)
        {
            // TODO: Domenik setzt hier menu visibility ein 
        }
        public static void Close()
        {
            System.Environment.Exit(0);
        }
    }
}
