using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VocableTrainer
{
    class GUIGame
    {
        private GUIGame() { }
        private static GUIGame instance;
        public static GUIGame getInstance() {
            if(instance == null)
            {
                instance = new GUIGame();
                instance.next();
            }
            return instance;
        }

        public String Answer1 { get; set; }
        public String Answer2 { get; set; }
        public String Answer3 { get; set; }
        public String Answer4 { get; set; }
        public String Question { get; set; }
        public String Solution { get; set; }
        public Boolean CheckAnswer(string answer)
        {
            return answer == Solution;
        }
        public void next()
        {
            Answer1 = "";
            Answer2 = "";
            Answer3 = "";
            Answer4 = "";
            Solution = "";
            Question = "";
            QuestionGenerator.generateQuestion();
            Console.WriteLine(Answer1 + " " + Answer2 + " " + Answer3 + " " + Answer4 + " " + Question + " " + Solution);
        }
    }

}
