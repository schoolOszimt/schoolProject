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
        private static Points points = Points.getInstance();
        private static GUIHandler handler = GUIHandler.getInstance();
        private GUIGame() { }
        private static GUIGame instance;
        public static GUIGame getInstance() {
            if(instance == null)
            {
                instance = new GUIGame();
                instance.newRandom();
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
            points.wasAnswerRight(answer == instance.Solution);
            return answer == instance.Solution;
        }
        public static void next()
        {
            instance.newRandom();
        }
        private void newRandom()
        {
            instance.Answer1 = "";
            instance.Answer2 = "";
            instance.Answer3 = "";
            instance.Answer4 = "";
            instance.Solution = "";
            instance.Question = "";
            QuestionGenerator.generateQuestion();
        }
        public static void newGame()
        {
            // TODO: Dominik fügt hier den new game oder reset button ein
            points.reset();
            instance.newRandom();
        }
        public void setVisibility(bool visibility)
        {
            if(visibility)
            {
                points.reset();
                instance.newRandom();
            }
            // TODO: Dominik fügt hier die Gameseite ein bzw macht sie sichtbar
        }
        public static void close()
        {
            // TODO: Dominik fügt hier den BackButton ein 
            handler.toMenu();
        }
    }

}
