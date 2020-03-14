using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public String Answer1 { get; set; }
        public String Answer2 { get; set; }
        public String Answer3 { get; set; }
        public String Answer4 { get; set; }
        public String Question { get; set; }
        public String Solution { get; set; }
        public static Boolean CheckAnswer(string answer)
        {
            points.WasAnswerRight(answer == instance.Solution);
            return answer == instance.Solution;
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
            // TODO: Dominik fügt hier den new game oder Reset button ein
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
            // TODO: Dominik fügt hier die Gameseite ein bzw macht sie sichtbar
        }
        public static void Close()
        {
            // TODO: Dominik fügt hier den BackButton ein 
            handler.ToMenu();
        }
    }

}
