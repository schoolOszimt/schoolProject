using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VocableTrainer
{
    class QuestionGenerator
    {
        private static Random random = new Random();
        private static List<Vocable> vocableList;
        private static GUIGame gui = GUIGame.getInstance(); 
        public QuestionGenerator()
        {
            vocableList = XMLReader.getAllVocable();
            generateQuestion();
        }
        private static String makeAnswer()
        {
            int i = random.Next(0, vocableList.Count);
            string answer = vocableList[i].Translation;
            while (checkOnDouble(answer))
            {
                i = random.Next(0, vocableList.Count);
                answer = vocableList[i].Translation;
            }
            return answer;
        }
        public static void generateQuestion()
        {
            if (vocableList == null) vocableList = XMLReader.getAllVocable();
            gui.Answer1 = makeAnswer();
            gui.Answer2 = makeAnswer();
            gui.Answer3 = makeAnswer();
            gui.Answer4 = makeAnswer();
            makeSolutionAndVocableRandom();
        }

        private static bool checkOnDouble(String answer)
        {
            return gui.Answer1 == answer || gui.Answer2 == answer || gui.Answer3 == answer || gui.Answer4 == answer;
        }
        private static void makeSolutionAndVocableRandom()
        {
            int i = random.Next(1, 4);
            switch (i)
            {
                case 1:
                    setSolutionAndVocable(gui.Answer1);
                    return;
                case 2:
                    setSolutionAndVocable(gui.Answer2);
                    return;
                case 3:
                    setSolutionAndVocable(gui.Answer3);
                    return;
                case 4:
                    setSolutionAndVocable(gui.Answer4);
                    return;
            }
        }
        private static void setSolutionAndVocable(String answer)
        {
            foreach(Vocable voc in vocableList)
            {
                if(voc.Translation == answer)
                {
                    gui.Question = voc.VocableValue;
                    gui.Solution = voc.Translation;
                }
            }
        }
    }
}
