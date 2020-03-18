using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VocableTrainer
{
    class GUIGame
    {
        private static Points points = Points.GetInstance();
        private static GUIHandler handler = GUIHandler.GetInstance();
        private GUIGame() { }
        private static GUIGame instance;
        public static GUIGame GetInstance() {
            if(instance == null)
            {
                instance = new GUIGame();
                instance.NewRandom();
            }
            return instance;
        }

        public string Answer1 { get; set; }
        public string Answer2 { get; set; }
        public string Answer3 { get; set; }
        public string Answer4 { get; set; }
        public string Question { get; set; }
        public string Solution { get; set; }
        public static bool CheckAnswer(string answer, bool IsAnswerCorrectWithoutPoints)
        {
            if (IsAnswerCorrectWithoutPoints)
            {
                return answer == instance.Solution;
            }
            else
            {
                points.WasAnswerRight(answer == instance.Solution);
                return answer == instance.Solution;
            }
            
        }
        public static void Next()
        {
            instance.NewRandom();
        }
        private void NewRandom()
        {
            instance.Answer1 = "";
            instance.Answer2 = "";
            instance.Answer3 = "";
            instance.Answer4 = "";
            instance.Solution = "";
            instance.Question = "";
            QuestionGenerator.GenerateQuestion();
        }
        public static void newGame()
        {
            // TODO: Domenik fügt hier den new game oder Reset button ein

            points.Reset();
            instance.NewRandom();
        }
        public void SetVisibility(bool visibility)
        {

            if(visibility)
            {
                points.Reset();
                instance.NewRandom();
            }
            
            // TODO: Domenik fügt hier die Gameseite ein bzw macht sie sichtbar
        }
        public static void Close()
        {
            // TODO: Domenik fügt hier den BackButton ein #erledigt
            handler.ToMenu();
        }
    }

}
