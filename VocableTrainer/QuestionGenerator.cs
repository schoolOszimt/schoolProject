using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace VocableTrainer
{
    class QuestionGenerator
    {
        private static Random random = new Random();
        public static List<Vocable> vocableList;
        private static GUIGame guigame = GUIGame.GetInstance(); 
        public QuestionGenerator()
        {
            GenerateQuestion();
        }
        private static string MakeAnswer()
        {
            int i = random.Next(0, vocableList.Count);
            string answer = vocableList[i].Translation;
            while (CheckOnDouble(answer))
            {
                i = random.Next(0, vocableList.Count);
                answer = vocableList[i].Translation;
            }
            return answer;
        }
        public static void GenerateQuestion()
        {
            vocableList = XMLReader.GetAllVocable();
            if (vocableList.Count < 4)
            {
                MessageBox.Show("Es ist ein Fehler in Ihrer Vokabelliste aufgetreten. Bitte konsultieren Sie Ihren Systemverwalter."
                     + Environment.NewLine + "Lösungshinweis: Die Liste enthält zu wenige Vokabeln.(min. 4)",
                    "Fehler in der XML-Datei", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Environment.Exit(1);
            }
            else
            {
                guigame.Answer1 = MakeAnswer();
                guigame.Answer2 = MakeAnswer();
                guigame.Answer3 = MakeAnswer();
                guigame.Answer4 = MakeAnswer();
                MakeSolutionAndVocableRandom();
            }
        }

        private static bool CheckOnDouble(string answer)
        {
            return guigame.Answer1 == answer || guigame.Answer2 == answer || guigame.Answer3 == answer || guigame.Answer4 == answer;
        }
        private static void MakeSolutionAndVocableRandom()
        {
            int i = random.Next(1, 5);
            switch (i)
            {
                case 1:
                    SetSolutionAndVocable(guigame.Answer1);
                    return;
                case 2:
                    SetSolutionAndVocable(guigame.Answer2);
                    return;
                case 3:
                    SetSolutionAndVocable(guigame.Answer3);
                    return;
                case 4:
                    SetSolutionAndVocable(guigame.Answer4);
                    return;
            }
        }
        private static void SetSolutionAndVocable(string answer)
        {
            foreach(Vocable voc in vocableList)
            {
                if(voc.Translation == answer)
                {
                    guigame.Question = voc.VocableValue;
                    guigame.Solution = voc.Translation;
                }
            }
        }
    }
}
