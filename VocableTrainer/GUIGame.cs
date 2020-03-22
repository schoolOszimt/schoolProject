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
        public static bool IsAnswerCorrect(string answer, bool isAnswerCorrectWithoutPoints)
        {
            if (isAnswerCorrectWithoutPoints)
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
        public static void NewGame()
        {
            points.Reset();
            instance.NewRandom();
        }
    }

}
