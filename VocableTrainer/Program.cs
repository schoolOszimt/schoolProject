using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VocableTrainer
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            GUIHandler.GetInstance();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new vT_Form());
            GUIGame game = GUIGame.GetInstance();
            Debug.WriteLine(game.Solution + " " + game.Answer1 + " " + game.Answer2 + " " + game.Answer3 + " " + game.Answer4 + " " + game.Question);
            GUIGame.Next();
            Debug.WriteLine(game.Solution + " " + game.Answer1 + " " + game.Answer2 + " " + game.Answer3 + " " + game.Answer4 + " " + game.Question);
            GUIGame.Next();
            Debug.WriteLine(game.Solution + " " + game.Answer1 + " " + game.Answer2 + " " + game.Answer3 + " " + game.Answer4 + " " + game.Question);
            Console.ReadLine();
        }
    }
}
